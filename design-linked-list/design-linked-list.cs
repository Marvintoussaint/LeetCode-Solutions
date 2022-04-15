public class MyLinkedList {
    
    public class Node
    {
       public  int val;
        
        public Node next;
        
        public Node(int val)
        {
            this.val = val;
        }
    }
    
    
        Node head;

        int size;
    
    

    public MyLinkedList() {
        head = new Node(-1);
        size = 0;
    }
    
    public int Get(int index) {
        if ( index >= size || index < 0)
            {
                return -1;
            }

            int count = 0;
            Node curr = head;

            while (count <= index)
            {
                curr = curr.next;
                count++;
             }

            return curr.val;
        
    }
    
    public void AddAtHead(int val) {
       AddAtIndex(0,val); 
    }
    
    public void AddAtTail(int val) {
      AddAtIndex(size,val);  
    }
    
    public void AddAtIndex(int index, int val) {
                    if (index > size)
            {
                return;
            }

            if (index < 0)
            {
                index = 0;
            }

            int count = 0;
            Node curr = head;

            while (count < index)
            {
                curr = curr.next;
                count++;
            }

            Node node = new Node(val);
            node.next = curr.next;
            curr.next = node;
            size ++;
    }
    
    public void DeleteAtIndex(int index) {
            if (index >= size)
            {
                return;
            }

            int count = 0;
            Node curr = head;

            while (count < index)
            {
                curr = curr.next;
                count++;
            }
            curr.next = curr.next.next;
            size--;
        
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */