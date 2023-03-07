namespace Core.Entity
{
    public class Engine
    {
        public int Id { get; set; }
        public int TypeEngineId { get; set; } // тип мотора (TypeEngine)
        public double Horsepower { get; set; } // мощность мотора в лошадиных силах
        public double Volume { get; set; } // объем двигателя
        public int? Cylinders { get; set; } // Число цилиндров
        public double Weight { get; set; } // Вес двигателя
        public int FuelConsumption { get; set; } // Потребление 1 литра топлива на км
        public TypeEngine TypeEngine { get; set; }
    }
}
