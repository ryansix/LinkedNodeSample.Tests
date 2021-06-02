using System.Collections.Generic;
using System.Text;
namespace LinkedNodeSample.Tests
{
    public class ListNode<T>
    {
        public T Value { get; private set; }
        public ListNode<T> next { get; private set; }
        public void ChangeNextNode(ListNode<T> next)
        {
            this.next = next;
        }
        public ListNode(T value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }

    /// <summary>
    /// 1. 黨沒有一個元素的時候，head、tail 都爲空,size = 0
    /// 2. 儅僅有一個元素的時候 head = tail,next 都等於空
    /// 
    /// </summary>
    public class LinkedNode
    {
        /// <summary>
        /// 頭部
        /// </summary>
        /// <value></value>
        public ListNode<string> head { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public ListNode<string> tail { get; private set; }
        public int size { get; private set; }
        public LinkedNode()
        {
            head = null;
            tail = null;
            size = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position">添加的位置</param>
        /// <param name="value">數值</param>
        public void insert(int position, string value)
        {
            var newNode = new ListNode<string>(value);
            if (position > size) return;  //超過數值

            if (position == 0)
            {

                if (tail == null)
                {
                    this.head = newNode;
                    this.tail = newNode;
                }
                else
                {
                    // 1. newNode.next 為head
                    // 2. 鏈表的頭部更改爲新node
                    newNode.ChangeNextNode(head);
                    this.head = newNode;
                }
            }
            else if (position == size)
            {
                //apend
                this.tail.ChangeNextNode(newNode);
                this.tail = newNode;
            }
            else
            {

                ListNode<string> temp = head;
                while (temp != null)
                {
                    position--;
                    if (position == 0)
                    {
                        newNode.ChangeNextNode(temp.next);
                        temp.ChangeNextNode(newNode);
                        size++;
                        return;
                    }
                    temp = temp.next;
                }
            }
            size++;
        }
        public void remove(int position)
        {
            if (position > size) return;
            if (position == 0)
            {
                this.head = this.head.next;
            }
            else 
            {
                var num = 0;
                 var temp = head;
                while (temp != null)
                {
                    num++;
                    if (position == num)
                    { 
                        if(temp.next!=null)
                            temp.ChangeNextNode(temp.next.next);
                    }
                    temp = temp.next;
                }
                  if(position == size)
                {
                    this.tail = temp;
                }
            }
        }
        public override string ToString()
        {
            if (head == null) return string.Empty;
            if (head.next == null) return head.ToString();

            var list = new List<string>();
            var temp = head;
            while (temp != null)
            {
                list.Add(temp.ToString());

                temp = temp.next;
            }
            return string.Join(',', list);
        }
    }


}