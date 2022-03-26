
laba_4s.Head head = new laba_4s.Head("10 рокiв", 10000, "Tom");
head.InfoEmp();

laba_4s.Mechanic mechanic = new laba_4s.Mechanic("1 рiк", 500, "Bob");
mechanic.InfoEmp();

laba_4s.Engineer_architect eng_arc = new laba_4s.Engineer_architect("4 рiк", 600, "Honor");
eng_arc.InfoEmp();

laba_4s.Engineer engineer = new laba_4s.Engineer("9 рiк", 200, "Ketren", 30);
engineer.InfoEmp();
engineer.Info();

laba_4s.Manager manager = new laba_4s.Manager("5 рiк", 300, "Mary");
manager.InfoEmp();
Console.WriteLine($"Кiлькiсть пiдлеглих у менеджера: {laba_4s.Mechanic.Num() + laba_4s.Engineer.Num() + laba_4s.Engineer_architect.Num()}\n");



