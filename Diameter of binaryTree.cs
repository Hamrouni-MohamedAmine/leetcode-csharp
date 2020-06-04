public static int DiameterOfBinaryTree (TreeNode root) {
    int MaxLeft = 0, MaxRight = 0;
    if (root == null) {
        return 0;
    }
    if (root.left != null)
        MaxLeft = MaxLength (root.left);
    if (root.right != null)
        MaxRight = MaxLength (root.right);
    return MaxLeft + MaxRight;
}

public static int MaxLength (TreeNode root) {
    var left = root;
    var right = root;
    int countLeft = 0, countRight = 0;
    if (root == null)
        return 0;
    if (root.left != null) {
        left = root.left;
        countLeft++;
        countLeft += MaxLength (left);

    }

    if (root.right != null) {
        right = root.right;
        countRight++;
        countRight += MaxLength (right);

    }

    return Math.Max (Math.Max (countLeft, countRight), countLeft + countRight);
}