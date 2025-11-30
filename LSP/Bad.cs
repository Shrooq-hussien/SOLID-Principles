public class Bird{ public virtual void Fly(){} }
public class Ostrich:Bird{ public override void Fly(){ throw new System.Exception(); } }