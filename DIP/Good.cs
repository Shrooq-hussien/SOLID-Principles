public interface IDevice{ void On(); }
public class Lamp:IDevice{ public void On(){} }
public class Switch{ IDevice d; public Switch(IDevice dev){d=dev;} public void On()=>d.On(); }