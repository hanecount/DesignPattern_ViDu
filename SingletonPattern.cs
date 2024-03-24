// // Creational Design Pattern
// // tao va tra ve nhieu doi tuong lop con ma chi can khoi tao 1 lan
// namespace SingletonDesignPattern{
//     internal sealed class Singleton{
//         private static int counter = 0;
//         private static Singleton instance = null;
//         public static Singleton GetInstance{
//             get
//             {
//                 if (instance == null)
//                     instance = new Singleton();
//                 return instance;  
//             }
//         }

//         public Singleton(){
//             counter++;
//             Console.WriteLine(counter);
//         }

//         public void PrintDetail(string chr){
//             Console.WriteLine(chr);
//         }
//     }

//     public class exec{
//         public static void Main(string[] arr){
//             Singleton obj = Singleton.GetInstance;
//             obj.PrintDetail("1st");
//             Singleton obj2 = Singleton.GetInstance;
//             obj2.PrintDetail("2nd");
//             Console.ReadLine();
//         }
//     }
// }