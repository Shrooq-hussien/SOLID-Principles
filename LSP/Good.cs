public interface IBird{}
public interface IFlyingBird:IBird{ void Fly(); }
public class Sparrow:IFlyingBird{ public void Fly(){} }
public class Ostrich:IBird{}