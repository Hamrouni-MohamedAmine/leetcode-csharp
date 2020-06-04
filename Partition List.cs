  public Node Partition(Node node, int x)
        {
            var afterStart = new Node(0);
            var afterEnd = new Node(0);
            var beforeStart = new Node(0);
            var beforeEnd =  new Node(0);

            while(node != null)
            {
                Node next = node.next;
                node.next = null;
                if(node.val < x)
                {
                    if(beforeStart == null)
                    {
                        beforeStart = node;
                        beforeEnd = beforeStart;
                    }
                    else
                    {
                        beforeEnd.next = node;
                        beforeEnd = node;
                    }

                }
                else
                {
                    if (afterStart == null)
                    {
                        afterStart = node;
                        afterEnd = afterStart;
                    }
                    else
                    {
                        afterEnd.next = node;
                        afterEnd = node;
                    }
                }

                node = next;
            }

           if(beforeStart == null)
            {
                return afterStart;
            }
            beforeEnd.next = afterStart;
            return beforeEnd;

        }