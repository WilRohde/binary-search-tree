namespace BinarySearchTree {
    class BSTree {
        private BSNode mo_Root;
        
        public BSNode Root {
            get 
            {
                return mo_Root; 
            }
            set
            {
                mo_Root = value;
            }
        }
        public BSTree() {
            return this;
        }
    }
}