// //che di su phuc tap cua he thong cung cap giao dien don gian cho client
// using FacadeDesignPattern;

// namespace FacadeDesignPattern{
//     public class Product{
//         public void GetProductDetails(){
//             Console.WriteLine("Product details");
//         }          
//     }

//     public class Payment{
//         public void MakePayment(){             
//             Console.WriteLine("Payment Success");
//         }    
        
//     }

//     public class Invoice{
//         public void SendInvoice(){
//             Console.WriteLine("Send Invoice");
//         }
//     }

//     public class Order{
//         public void PlaceOrder(){
//             Product product = new Product();
//             product.GetProductDetails();
//             Payment payment = new Payment();
//             payment.MakePayment();
//             Invoice invoice= new Invoice();
//             invoice.SendInvoice();
//             Console.ReadLine();
//         }
//     }

//     public class exec{
//         public static void Main(string[] arr){
//             Order obj = new Order();
//             obj.PlaceOrder();
//         }
//     }
// }