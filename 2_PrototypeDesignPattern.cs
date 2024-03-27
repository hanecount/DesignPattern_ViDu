// //tao doi tuong bang cach copy doi tuong da co khong lam thay doi gia tri cua doi tuong cu

// namespace PrototypeDesignPattern{
//     public class Prototype{
//         public string name{get;set;}
//         public Prototype GetClone(){
//             return (Prototype)this.MemberwiseClone();
//         }
//     }

//     public class exec{
//         public static void Main(string[] arr){
//             Prototype obj1 = new Prototype();
//             obj1.name = "Han";
//             Console.WriteLine(obj1.name);
//             Prototype obj2 =  obj1.GetClone();
//             obj2.name = "ngoc";
//             Console.WriteLine(obj2.name);
//             Console.ReadLine();
//         }
//     }
// }