namespace binarysearchtree
{
class BSNode {
        private Driver mo_driver;
        private BSNode mo_LeftNode;
        private BSNode mo_RightNode;

        public Driver driver
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
        public BSNode(driver dDriver){
            mo_driver = dDriver;
        }
        
        public BSNode(driver dDriver, BSNode bsLeftNode) {
            mo_driver = dDriver;
            mo_LeftNode = bsLeftNode;
        }

        public dNode(driver dDriver, BSNode bsLeftNode, BSNode bsRightNode) {
            mo_driver = dDriver;
            mo_LeftNode = bsLeftNode;
            mo_RightNode = bsRightNode;
        }
    }
}
