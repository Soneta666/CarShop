using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class mmmmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_TypeEngines_TypeEngineId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Years_IdYear",
                table: "Models");

            migrationBuilder.DropTable(
                name: "TypeEngines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_TypeEngineId",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "TypeEngineId",
                table: "Engines");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Years",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "IdYear",
                table: "Models",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "TypeEngine",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "Cylinders", "FuelConsumption", "Horsepower", "TypeEngine", "Volume", "Weight" },
                values: new object[,]
                {
                    { 1, 2, 5, 60.0, "Diesel", 1.3, 220.0 },
                    { 2, 3, 6, 140.0, "Petrol", 1.5, 240.0 },
                    { 3, 4, 8, 180.0, "Petrol", 2.0, 350.0 },
                    { 4, 5, 9, 220.0, "Petrol", 2.2000000000000002, 350.0 },
                    { 5, 6, 10, 280.0, "Diesel", 2.5, 450.0 },
                    { 6, 8, 12, 370.0, "Diesel", 3.0, 700.0 },
                    { 7, 10, 14, 500.0, "Petrol", 5.0, 800.0 },
                    { 8, 12, 18, 700.0, "Petrol", 6.0, 800.0 }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Germany", "Volkswagen" },
                    { 2, "Japan", "Toyota" },
                    { 3, "Italy", "Stellantis" },
                    { 4, "Germany", "Mercedes Benz" },
                    { 5, "United States", "Ford" },
                    { 6, "United States", "General Motors" },
                    { 7, "Japan", "Honda" },
                    { 8, "United States", "Tesla" },
                    { 9, "Japan", "Nissan" },
                    { 10, "China", "BYD Co. Ltd." },
                    { 11, "Germany", "BMW" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "IdYear", "Name" },
                values: new object[,]
                {
                    { 1, "The most common car type is the sedan. A sedan is a four-door car type with a traditional trunk. The difference between a hatchback and a sedan is that the rear luggage compartment door does not include the rear window and the door hinges are installed under the window.", null, "Sedan" },
                    { 2, "A crossover is often confused with an SUV. A crossover often comes as two-wheel drive, but it can also come with 4-wheel drive. It is basically an off-road car chassis, but built more for city traffic.", null, "Crossover (CUV)" },
                    { 3, "Another type that climbs this list of car types is the SUV, which is becoming more and more popular. The SUV is a large car that can often carry five to seven passengers with three rows of seats. They are basically the same as a crossover, except that they are built on a body-on-frame chassis. They often have 4wd and good terrain capability.", null, "Sport Utility Vehicles (SUVs)" },
                    { 4, "A Hatchback car is basically a mix of a sedan and a station wagon. They often come as a 5-door set and have a hatch that opens upwards. Like the station wagon, a hatchback has door hinges above the rear window.", null, "Hatchback" },
                    { 5, "A wagon is quite similar to a sedan, but with an extended roofline with a hatch door instead of a trunk. Station cars are often the perfect choice for families and long car journeys due to the larger cargo space than the sedan.", null, "Station Wagon" },
                    { 6, "The coupe is a two-door car, very similar to the sedan but with two doors instead of four. Coupé cars often have a rear seat for two or three more passengers, but you often have to fold down one of the front seats to get there. Coupé cars are often quite more towards the sporty look.", null, "Coupe" },
                    { 7, "Pickup trucks have become very common in recent years. A pickup has an enclosed cab with an open cargo area. They can either have space for two passengers or four. Pickup trucks have the cabin mounted on a separate steel frame, with one exception – Honda Ridgeline.", null, "Pickup Truck" },
                    { 8, "The minivan or multi-purpose vehicle (MPV) is a van, but instead of cargo space, it has passenger seats. It often has 7 or 8 passenger seats, making it perfect for larger families or being used as a taxi.", null, "Minivan (MPV)" },
                    { 9, "A roadster car is basically a convertible car, but with two doors, and it usually has no rear seat. They are therefore good for only two people. When it comes to size, they are often very small, with limited cargo space.", null, "Roadster" },
                    { 10, "A Van is a two- or three-seater car model that is often used to transport goods. They often have a sealed cab from the cargo area, and they often have no windows to the cargo area, but some models have glass windows at the rear doors.", null, "Van" },
                    { 11, "A sports car is anything that looks sporty to you, and it can be a roadster, coupe, or even a sedan. Sports cars are quite similar to the supercar, because a supercar can also be a sports car, but the difference is often that the sports car is a step below the supercar regarding performance and price.", null, "Sports Cars" },
                    { 12, "The supercar is a high-performance car, usually with a very powerful and large engine. Most supercars are two-seater and at the same time very expensive – some are going for as high as one million dollars.", null, "Supercar" },
                    { 13, "A luxury car is exactly what it sounds like – luxury. They are often very expensive, and have all the latest features for a comfortable ride. They often have a very powerful engine, but are not very fast in curves and on racetracks. This is because they often have so many features for comfort, so they are usually very heavy.", null, "Luxury Cars" },
                    { 14, "The convertible or cabriolet car models come with a retractable roof. They are the perfect choice for a hot summer day when you are going on holiday to the beach. Most convertible cars have an automatic system to retrace the fabric rooftop, but on some older models, you had to do this manually. Some models even have a retractable hardtop, which makes them look like normal cars when the rooftop is closed.", null, "Cabriolet" },
                    { 15, "Muscle cars are cars with large muscles under the hood. Muscle cars are often older American cars with very large and powerful v8 or v10 engines, but muscle cars are also available as modern cars. Muscle cars are usually not that fast on racetracks around corners, but when they drive in a straight line, like drag racing, not many other cars can beat them.", null, "Muscle Cars" },
                    { 16, "The microcar or minicar is a small car that often comes with an engine size of less than a liter. They are available in various unusual designs and are ideal for city traffic due to their fuel efficiency and easy parking.", null, "Micro" },
                    { 17, "A camper van is often a truck chassis that has been rebuilt for camping, and they often have a kitchen, toilet, and other necessary accessories for a perfect camping trip. For example, a motorhome can also refer to a minivan that has been rebuilt for camping, such as a Volkswagen transporter.", null, "Camper Van" },
                    { 18, "A mini truck is exactly what it sounds like – a small truck, and it’s a mix of a pickup and a truck. They often have two or three seats and open cargo space but can also come with closed cargo space.", null, "Mini Truck" },
                    { 19, "A limousine is a stretched car that is often used by celebrities and pop stars. It has an elongated base and can be rebuilt from different car models.", null, "Limousine" },
                    { 20, "In the last place on the list, you will find the truck. Although they are not really a car type, they can come in many forms and are still a vehicle type, so we wanted to include it.", null, "Truck" },
                    { 21, "A hot hatch car is very similar to a hatchback car, which we talked about earlier in the article. However, a hot hatch is a hatchback that has been modified to improve performance and is generally a little more “sporty”.", null, "Hot Hatch" },
                    { 22, "A grand tourer is typically a high-performance luxury car designed for long-distance driving. The term “grand tourer” or just “GT” is sometimes used to describe just a high-performance sports car, but the typical grand tourer is larger and more comfortable than a sports car.", null, "Grand Tourer" },
                    { 23, "Utes are popular in Australia and New Zealand, where they are often used as work vehicles. Ute is short for “coupé utility” or “utility”. Ute is a regular car that has been modified with a cargo bed in the back, instead of passenger seats. This makes it perfect for carrying large objects, such as timber or building materials.", null, "Ute" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "IdYear", "Name" },
                values: new object[,]
                {
                    { 24, "A military vehicle is exactly what it sounds like: a vehicle that is designed for or has been adapted to be used by the military. This includes tanks, armored personnel carriers, artillery, and other types of vehicles used by the military.", null, "Military Vehicle" },
                    { 25, "A dragster is built to compete in drag racing. A typical drag race is a race in a straight line from one end of a track to another, and the goal is to reach the finish line first. To achieve this, dragsters rely on their incredible speed and acceleration, which is why some dragster cars have over 8,000 horsepower.", null, "Dragster" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 1, "2023" },
                    { 2, "2022" },
                    { 3, "2021" },
                    { 4, "2020" },
                    { 5, "2019" },
                    { 6, "2018" },
                    { 7, "2017" },
                    { 8, "2016" },
                    { 9, "2015" },
                    { 10, "2014" },
                    { 11, "2013" },
                    { 12, "2012" },
                    { 13, "2011" },
                    { 14, "2010" },
                    { 15, "2009" },
                    { 16, "2008" },
                    { 17, "2007" },
                    { 18, "2006" },
                    { 19, "2005" },
                    { 20, "2004" },
                    { 21, "2003" },
                    { 22, "2002" },
                    { 23, "2001" },
                    { 24, "2000" },
                    { 25, "1999" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "EngineId", "MakeId", "MaxSpeed", "Mileage", "ModelId", "Name", "Price", "SecondSpeed", "YearId" },
                values: new object[] { 1, 3, 1, 260.0, 12.0, 2, "Audi Q5", 68.013999999999996, 60.0, 2 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "EngineId", "MakeId", "MaxSpeed", "Mileage", "ModelId", "Name", "Price", "SecondSpeed", "YearId" },
                values: new object[] { 2, 7, 4, 300.0, 60.0, 6, "Mercedes-Benz CLS 63 AMG S", 62.0, 70.0, 9 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "EngineId", "MakeId", "MaxSpeed", "Mileage", "ModelId", "Name", "Price", "SecondSpeed", "YearId" },
                values: new object[] { 3, 3, 3, 220.0, 180.0, 6, "Skoda Superb 2.0 TDI 4x4", 16.0, 50.0, 7 });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_YearId",
                table: "Cars",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Years_YearId",
                table: "Cars",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Years_IdYear",
                table: "Models",
                column: "IdYear",
                principalTable: "Years",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Years_YearId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Years_IdYear",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Cars_YearId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "TypeEngine",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Cars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Years",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IdYear",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeEngineId",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TypeEngines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEngines", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engines_TypeEngineId",
                table: "Engines",
                column: "TypeEngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_TypeEngines_TypeEngineId",
                table: "Engines",
                column: "TypeEngineId",
                principalTable: "TypeEngines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Years_IdYear",
                table: "Models",
                column: "IdYear",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
