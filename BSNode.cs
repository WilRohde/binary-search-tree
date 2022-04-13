namespace binarysearchtree
{
class BSNode {
        private string mo_NodeValue;
        private BSNode mo_LeftNode;
        private BSNode mo_RightNode;

        public string nodeValue
        {
            get 
            {
                return mo_NodeValue; 
            }
            set
            {
                mo_nodeValue = value; 
            }
        }

        public BSNode LeftNode {
            get
            {
                return mo_LeftNode; 
            }
            set
            {
                mo_LeftNode = value; 
            }
        }

        public BSNode RightNode {
            set 
            {
                return mo_RightNode; 
            }
            set 
            {
                mo_RightNode = value; 
            }
        }
        public BSNode(string sValue){
            mo_NodeValue = sValue;
        }
        
        public BSNode(string sValue, BSNode bsLeftNode) {
            mo_NodeValue = sValue;
            mo_LeftNode = bsLeftNode;
        }

        public dNode(string sValue, BSNode bsLeftNode, BSNode bsRightNode) {
            mo_NodeValue = sValue;
            mo_LeftNode = bsLeftNode;
            mo_RightNode = bsRightNode;
        }
    }
}
