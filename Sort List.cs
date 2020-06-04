 public static Node Partition (Node node) {
     if (node == null || node.Next == null) {
         return node;
     }
     var temp = node;
     var left = node;
     var right = node;

     while (right != null && right.Next != null) {
         temp = left;
         left = left.Next;
         right = right.Next.Next;
     }

     temp.Next = null;
     Node leftNode = Partition (node);
     Node rightNode = Partition (left);
     return Merge (leftNode, rightNode);
 }

 private static Node Merge (Node left, Node right) {
     var Node = new Node (0);
     var currentNode = Node;
     while (left != null && right != null) {
         if (left.Value <= right.Value) {
             currentNode.Next = left;
             left = left.Next;
         } else {
             currentNode.Next = right;
             right = right.Next;
         }
         currentNode = currentNode.Next;
     }

     if (left != null) {
         currentNode.Next = left;
         left = left.Next;
     }

     if (right != null) {
         currentNode.Next = right;
         right = right.Next;
     }
     return Node.Next;

 }