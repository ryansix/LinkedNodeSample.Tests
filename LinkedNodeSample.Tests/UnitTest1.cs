using System;
using Xunit;

namespace LinkedNodeSample.Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// init 新增兩個元素都在head
        /// </summary>
        /// <returns></returns>
        [Fact]
        public LinkedNode InsertZeroPosition()
        {
            var linkedNode = new LinkedNode();
            linkedNode.insert(0,"2");
            linkedNode.insert(0,"1");
             return linkedNode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
         [Fact]
        public LinkedNode InsertAfterTailPosition()
        {
            var linkedNode = InsertZeroPosition();
            linkedNode.insert(linkedNode.size,"4");
            linkedNode.insert(linkedNode.size,"5");
            var str = linkedNode.ToString();
             return linkedNode;
        }

        [Fact]
        public LinkedNode InsertSpecifyPosition(){
            var linkedNode = InsertAfterTailPosition(); 
            linkedNode.insert(2,"3");
             var str = linkedNode.ToString();
             return linkedNode;
        }

        [Fact]
        public void DeleteHeadPosition(){
            var linkedNode = InsertSpecifyPosition();
            linkedNode.remove(0);
        }
        [Fact]
        public void DeleteTailPosition(){
            var linkedNode = InsertSpecifyPosition();
            linkedNode.remove(linkedNode.size);//remove value=3
        }
        [Fact]
        public void DeleteSpecifyPosition(){
            var linkedNode = InsertSpecifyPosition();
            linkedNode.remove(2);//remove value=3
        }

    }
}
