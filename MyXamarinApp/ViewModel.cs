using System.Collections.ObjectModel;

namespace MyXamarinApp
{
    class ViewModel
    {
        public ObservableCollection<OrderInfo> OrderInfoCollection { get; set; }

        public ViewModel ()
        {
            OrderInfoCollection = new ObservableCollection<OrderInfo> ();
            GenerateOrders ();
        }

        private void GenerateOrders ()
        {
            OrderInfoCollection.Add(new OrderInfo(1001, "Maria Anders",100, "Mexico", "ANATR", "Mexico D.F.",true));
            OrderInfoCollection.Add(new OrderInfo(1002, "Ana Trujillo",240, "Mexico", "ANTON", "Mexico D.F.", true));
            OrderInfoCollection.Add(new OrderInfo(1003, "Ant Fuller", 210, "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1004, "Thomas Hardy", 549, "Sweden", "BERGS", "Berlin", true));
            OrderInfoCollection.Add(new OrderInfo(1005, "Lenny Lin", 900, "Germany", "BLAUS", "Mannheim", true));
            OrderInfoCollection.Add(new OrderInfo(1006, "John Carter", 78, "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1007, "Laura King", 40, "Spain", "BOLID", "Madrid", true));
            OrderInfoCollection.Add(new OrderInfo(1008, "Hanna Moos", 240, "France", "BONAP", "Marseille", false));
            OrderInfoCollection.Add(new OrderInfo(1009, "Lenny Lin", 1077, "Canada", "BOTTM", "Tsawassen", false));
            OrderInfoCollection.Add(new OrderInfo(1010, "Hanna Moos", 631, "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1011, "John Carter", 449, "Germany", "BLAUS", "Mannheim", false));
            OrderInfoCollection.Add(new OrderInfo(1012, "Tim Adams", 363, "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1013, "Hanna Moos", 40, "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1014, "John Carter", 723, "Germany", "ALFKI", "Berlin", true));
            OrderInfoCollection.Add(new OrderInfo(1015, "Hanna Moos", 310, "Mexico", "ANATR", "Mexico D.F.", false));
            OrderInfoCollection.Add(new OrderInfo(1016, "Laura King",740, "Mexico", "ANTON", "Mexico D.F.", false));
            OrderInfoCollection.Add(new OrderInfo(1017, "Len Lin", 196, "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1018, "Thomas Hardy", 580, "Sweden", "BERGS", "Berlin", true));
            OrderInfoCollection.Add(new OrderInfo(1019, "Lenny Lin", 761, "Germany", "BLAUS", "Mannheim", true));
            OrderInfoCollection.Add(new OrderInfo(1020, "Gina Irene", 178, "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1021, "Laura King", 516, "Spain", "BOLID", "Madrid", false));
            OrderInfoCollection.Add(new OrderInfo(1022, "Anne Wilson", 872, "France", "BONAP", "Marseille", true));
            OrderInfoCollection.Add(new OrderInfo(1023, "Lenny Lin", 220, "Canada", "BOTTM", "Tsawassen", false));
            OrderInfoCollection.Add(new OrderInfo(1024, "Gina Irene", 940, "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1025, "Thomas Hardy", 1240, "Germany", "BLAUS", "Mannheim", true));
            OrderInfoCollection.Add(new OrderInfo(1026, "Anne Wilson", 240, "France", "BLONP", "Strasbourg", false));
            OrderInfoCollection.Add(new OrderInfo(1027, "Laura King", 2140, "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1028, "Anne Wilson", 100, "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1029, "Gina Irene", 1440, "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1030, "Anne Wilson", 240, "Germany", "ALFKI", "Berlin", false));
            OrderInfoCollection.Add(new OrderInfo(1031, "Tim Adams", 384, "Mexico", "ANATR", "Mexico D.F.", true));
            OrderInfoCollection.Add(new OrderInfo(1032, "Hnne Wils", 656, "Mexico", "ANTON", "Mexico D.F.", true));
            OrderInfoCollection.Add(new OrderInfo(1033, "Gina Irene", 290, "UK", "AROUT", "London", false));
            OrderInfoCollection.Add(new OrderInfo(1034, "Ant Fuller", 340, "Sweden", "BERGS", "Berlin", true));
            OrderInfoCollection.Add(new OrderInfo(1035, "Thomas Hardy", 580, "Germany", "BLAUS", "Mannheim", false));
            OrderInfoCollection.Add(new OrderInfo(1036, "Gina Irene", 456, "France", "BLONP", "Strasbourg", true));
            OrderInfoCollection.Add(new OrderInfo(1037, "Hanna Moos", 754, "Spain", "BOLID", "Madrid", false));
            OrderInfoCollection.Add(new OrderInfo(1038, "Anne Wilson", 978, "France", "BONAP", "Marseille", false));
            OrderInfoCollection.Add(new OrderInfo(1039, "Thomas Hardy", 357, "Canada", "BOTTM", "Tsawassen", true));
            OrderInfoCollection.Add(new OrderInfo(1040, "Tim Adams", 964, "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1041, "Anne Wilson", 574, "Germany", "BLAUS", "Mannheim", true));
            OrderInfoCollection.Add(new OrderInfo(1042, "Thomas Wel", 986, "France", "BLONP", "Strasbourg", false));
            OrderInfoCollection.Add(new OrderInfo(1043, "Han Moos", 1345, "UK", "AROUT", "London", true));
            OrderInfoCollection.Add(new OrderInfo(1044, "John Wick", 548, "Germany", "ALFKI", "Berlin", false));
        }
    }
}
