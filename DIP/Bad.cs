public class Lamp{ public void TurnOn(){} }
public class Switch{ Lamp lamp=new Lamp(); public void On()=>lamp.TurnOn(); }