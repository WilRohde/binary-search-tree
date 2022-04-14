namespace BinarySearchTree
{
    class Driver
    {
        private string mo_firstname;
        private string mo_lastname;
        private integer mo_number;

        public string firstname {
            get{
                return mo_firstname;
            }
            set{
                mo_firstname = value;
            }
        }
        public string lastname {
            get{
                return mo_lastname;
            }
            set{
                mo_lastname = value;
            }
        }
        public integer number {
            get{
                return mo_number;
            }
            set{
                mo_number = value;
            }
        }
        new Driver(string firstname, string lastname, integer number) {
            this.mo_firstname = firstname;
            this.mo_lastname = lastname;
            this.mo_number = number;
        }
    }
}