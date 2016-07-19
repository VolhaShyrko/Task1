namespace Task1
{
    class Program
    {
        //Попытайтесь разорвать связь между классами через InfoData (класс Destination ничего не должен знать об этом типе)
        static void Main(string[] args)
        {
        }
        struct InfoData
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Source
        {
            internal void CheckAndProceed(InfoData[] data)
            {
                var dest = new Destination();

                //do something

                dest.ProceedData(data);
            }
        }

        class Destination
        {
            public void ProceedData<T>(T[] data) where T : struct
            {
                for (var i = 0; i < data.Length; i++)
                {
                    //do sth
                }
            }
        }
    }
}
