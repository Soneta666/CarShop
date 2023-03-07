﻿namespace Core.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public int MakeId { get; set; }          // Производитель (Make)
        public int ModelId { get; set; }         // Модель (Model)
        public int EngineId { get; set; }        // Мотор (Engine)
        public double Mileage { get; set; }      // Пробег
        public double MaxSpeed { get; set; }     // Скорость
        public double SecondSpeed { get; set; }  // Скорость за 1 секунду
        public Make Make { get; set; }
        public Model Model { get; set; }
        public Engine Engine { get; set; }
    }
}
