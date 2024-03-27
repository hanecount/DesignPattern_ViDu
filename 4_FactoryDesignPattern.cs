// // Creational Design Pattern
// // tao va tra ve doi tuong lop con tuong ung voi tham so dau vao nhan duoc
// // dung trong cac ung dung RealTime (thời gian thực) ex: thong bao tin nhan,...

// namespace FactoryDesignPattern{
//       interface ICreditCard{
//         string GetCardType();
//         int GetCreditLimit();  
//         int GetAnnualCharge();
//     }
    
//     internal class MoneyBack: ICreditCard{
//         public string GetCardType(){
//             return "MoneyBack";
//         }

//         public int GetCreditLimit(){
//             return 1;
//         }

//         public int GetAnnualCharge(){
//             return 2;
//         }
//     }

//     internal class Titanium: ICreditCard{
//         public string GetCardType(){
//             return "Titanium";
//         }

//         public int GetCreditLimit(){
//             return 3;
//         }

//         public int GetAnnualCharge(){
//             return 4;
//         }
//     }

//     internal class Platinum: ICreditCard{
//         public string GetCardType(){
//             return "Platinum";
//         }

//         public int GetCreditLimit(){
//             return 5;
//         }

//         public int GetAnnualCharge(){
//             return 6;
//         }
//     }


//     internal class FactoryBulder{
//         public static ICreditCard GetCreditCard(string cardType){
//             ICreditCard objectCard = null;
//             if(cardType == "MoneyBack"){
//                 objectCard = new MoneyBack();
//             }
//             else if(cardType == "Titanium"){
//                 objectCard = new Titanium();
//             }
//             else if(cardType == "Platinum"){
//                 objectCard = new Platinum();
//             }
//             return objectCard;
//         }
//     }

//     internal class exec{
//         public static void Main(string[] arr){
//             ICreditCard obj = FactoryBulder.GetCreditCard("Titanium");
//             if(obj != null){
//                 Console.WriteLine(obj.GetCardType());
//                  Console.WriteLine(obj.GetCreditLimit());
//                   Console.WriteLine(obj.GetAnnualCharge());
//             }
//             else
//                 Console.WriteLine("Invalid Card Type");
//         }
//     }

// }