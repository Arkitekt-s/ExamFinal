namespace ExamFinal.Advance;


    public static class ShoppingCartExtensions
    {
        //THIS IS REFER TO THE OBJECT THAT WE CALL THE METHOD ON EXTENDING
        public static double CalculateTotalPrice(this ShoppingCart cart)
        {
            double totalPrice = 0;
            foreach (var product in cart.Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }