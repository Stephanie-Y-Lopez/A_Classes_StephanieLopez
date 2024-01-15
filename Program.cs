namespace A_Classes_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez

        static void Main(string[] args)
        {
            // Test for Car class
            Car car1 = new Car();
            car1.Make = "Hyundai";
            car1.Model = "Sonata";
            car1.Year = 2022;
            car1.Color = "Fire Red";
            car1.Mileage = 10000;

            // Display of Car class
            Console.WriteLine($"Car Make: {car1.Make}");
            Console.WriteLine($"Car Model: {car1.Model}");
            Console.WriteLine($"Car Year: {car1.Year}");
            Console.WriteLine($"Car Color: {car1.Color}");
            Console.WriteLine($"Car Mileage: {car1.Mileage}");



            // Test for Bike class
            Bike bike1 = new Bike();
            bike1.Brand = "Trek";
            bike1.Type = "Mountain";
            bike1.Color1 = "Purple";
            bike1._NumberOfWheels = 2;
            bike1._NumberOfGears = 4;

            // Display of Bike class
            Console.WriteLine($"Bike Brand: {bike1.Brand}");
            Console.WriteLine($"Bike Type: {bike1.Type}");
            Console.WriteLine($"Bike Color: {bike1.Color1}");
            Console.WriteLine($"Number of Wheels: {bike1._NumberOfWheels}");
            Console.WriteLine($"Number of Gears: {bike1._NumberOfGears}");



            // Test for Music class
            Music music1 = new Music();
            music1.SongName = "La Bachata";
            music1.MadeBy = "Manuel Turizo";
            music1.Genre = "Bachata";
            music1.Language = "Spanish";
            music1.LengthOfSongInMinutes = 3;

            //Display of Music class
            Console.WriteLine($"Song Name: {music1.SongName}");
            Console.WriteLine($"Song By: {music1.MadeBy}");
            Console.WriteLine($"Song Genre: {music1.Genre}");
            Console.WriteLine($"Song Language: {music1.Language}");
            Console.WriteLine($"Length Of Song: {music1.LengthOfSongInMinutes}");
        }
    }
}