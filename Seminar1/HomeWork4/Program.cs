Console.WriteLine("Enter number");
int num=Convert.ToInt32(Console.ReadLine());
int numStart=1;
if (num<1){
    Console.WriteLine("Число меньше 1.");
}

else {
while(numStart<=num){
    if (numStart%2==0){
        Console.Write(numStart + ", ");
        numStart++;
    }
    else {
        numStart++;
    }        
    }


} 

