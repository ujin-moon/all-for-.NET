Transport auto = new Auto("машина");
Transport ship = new Ship("Корабль");
Transport aircraft = new Aircraft("Самолет");

auto.Speed = 70;
ship.Speed = 80;
aircraft.Speed = 720;

auto.Move();         // Легковая машина едет, со скоростью 70 км/ч
ship.Move();        // Корабль плывет, со скоростью 80 км/ч
aircraft.Move();    // Самолет летит, со скоростью 720 км/ч
