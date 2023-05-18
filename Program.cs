using System;
using System.Collections;
using System.Collections.Generic;

// Обобщенный класс для узла бинарного дерева
public class BinaryTreeNode<T> {
    public T Value { get; set; }
    public BinaryTreeNode<T> Left { get; set; }
    public BinaryTreeNode<T> Right { get; set; }
}

// Обобщенный класс-коллекция для бинарного дерева
public class BinaryTree<T> : IEnumerable<T> {
    private BinaryTreeNode<T> root;

    public void Add(T value) {
        var newNode = new BinaryTreeNode<T> { Value = value };

        if (root == null) {
            root = newNode;
        }
        else {
            AddTo(root, newNode);
        }
    }

    private void AddTo(BinaryTreeNode<T> node, BinaryTreeNode<T> newNode) {
        if (Comparer<T>.Default.Compare(newNode.Value, node.Value) < 0) {
            if (node.Left == null) {
                node.Left = newNode;
            }
            else {
                AddTo(node.Left, newNode);
            }
        }
        else {
            if (node.Right == null) {
                node.Right = newNode;
            }
            else {
                AddTo(node.Right, newNode);
            }
        }
    }

    // Реализация интерфейса IEnumerable<T>
    public IEnumerator<T> GetEnumerator() {
        return InOrderTraversal().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    // Метод для центрального обхода дерева
    private IEnumerable<T> InOrderTraversal() {
        if (root != null) {
            var stack = new Stack<BinaryTreeNode<T>>();
            var currentNode = root;

            while (stack.Count > 0 || currentNode != null) {
                if (currentNode != null) {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else {
                    currentNode = stack.Pop();
                    yield return currentNode.Value;
                    currentNode = currentNode.Right;
                }
            }
        }
    }
}

class Program {
    static void Main(string [] args) {
        // Создание бинарного дерева
        var tree = new BinaryTree<int>();
        tree.Add(5);
        tree.Add(3);
        tree.Add(7);
        tree.Add(1);
        tree.Add(4);
        tree.Add(6);
        tree.Add(9);

        // Использование дерева в цикле foreach
        foreach (var value in tree) {
            Console.WriteLine(value);
        }
    }
}
