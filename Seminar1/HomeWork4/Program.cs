Console.WriteLine("Enter number");
int num=Convert.ToInt32(Console.ReadLine());
int numStart=1;
if (num<1){
    Console.WriteLine("Число меньше 1.");
}

else {
    while(numStart<num-1){
    if (numStart%2==0){
        Console.Write(numStart + ", ");
        numStart++;
    }
    else {
        numStart++;
    }        
}


} 
if(num%2==0){
    Console.Write(num);
    }
else {
    Console.Write(num-1);
    }



