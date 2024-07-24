namespace LU1_Indexes_Demo
{//namespace begin
    //Indexers allow objects to be indexed in the same way as arays
    //This means you can access elements within an object using the array operator []
    //Indexers are defines using the 'this' keyword & can take ome/ more parameters
    //These parameters are seen as properties but instead of accesing a single value-
    //you are able to access multiplle values nusing the index
    //Parameters &Return-Type of the indexer can differ
    //Indexer can help enforce encapsulation of the ineranl data structure of the the class
    //Also provides a clean-array like syntax for access of elements
    internal class Program
    {//program class begin
        static void Main(string[] args)
        {//main end
            //create an instance of the Example class below
            Example example = new Example();

            //make use of the indexer

            //set the value at the index 0 of the above numbers array to 5 using the indexer
            example[0] = 5;

            //retrieve the value at the index 0 of the above numbers arrau using the indexer
            int value = example[0];

            //Output message to show the use of the indexer
            Console.WriteLine(value);//expected output: 5
        }//main end

        public class Example
        {//Example class begin
            //private array to hold integer values
            private int[] numbers = new int[10];

            //accessSpecififer dataType this[int index]
            //General syntax- {get & set}
            public int this[int index] //until put get/set there will be red line under this
            {
                //get & set to access & retrieve the value at a specified index
                get { return numbers[index]; } 
            set{numbers[index] = value;}
            }
        }//Example class end

    }//program class end
}//namespace end
