using System;
//using System.Collection.Generic;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace c_sharp_examples
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Program program=new Program();
        //     program.main();
        // }
        static void Main(string[] args)
        {
            Program program=new Program();
            #region "all methods calling"
        //    Console.WriteLine("\n please enter number for fun FuzzzBuzzz program");
        //    var usernumber=Console.ReadLine();
        //    if(int.TryParse(usernumber,out int num2))
        //    {
        //        program.fuzzbuzzmethod(usernumber);
        //    }
        //    else
        //    {Console.WriteLine("user input is not matching for processing, pls give numbers... :) ");}

        //    Console.WriteLine("Enter string to reverse : ");
        //    var reverstring=Console.ReadLine();
        //    program.reversestring(reverstring);
        //    Console.WriteLine("");

        //    Console.WriteLine("\n 5Enter prymarid layers : ");
        //    var prymidlayers=Console.ReadLine();
        //    if(int.TryParse(prymidlayers,out int lyrs))
        //    {
        //      program.printnumberprymaid(int.Parse(prymidlayers));
        //    }
        //    Console.WriteLine("");

        //     Console.WriteLine("\n write a string for finding duplicate characters");
        //     var str=Console.ReadLine();
        //    program.PrintCharactercount(str);

          // program.BalancePraenthesis("[A(a-b]23123])");
         //   program.BalancePraenthesis(")[]");
       //     program.BalancePraenthesis("[]");
        //    program.BalancePraenthesis("([{}])");

        //printing repeated character using dictionary
        //program.PrintRepeatedCharacterAndCount("aaaaccccbder");

        //reverse string using stack
        //program.reversestringusingstack("reversestringusingstack");
        //program.reversestringusingstack("step on no pets");
        //program.reversestringusingstack("1001");

        //finding first unique character in a given string
        ///program.findingFirstUniqueCharUsingIndexOf("aaaabbbbcllldde");


           //matrix traverse and reverse
           //program.traversematrix();
           
           //find missing number in array
           //program.Find_the_missing_number_in_the_array();
           
           //finding sum of 2 numbers
           //program.Find_sumof_Two_Values_EqualsTo();


           //Binary search 
        //    int[] sortedarray=new int[]{1,2,3,4,5,6,7,8,9,10,100};
        //    Console.WriteLine("items array");
        //    for(int i=0;i<sortedarray.Length;i++)
        //    {
        //        Console.Write(sortedarray[i]+" ");
        //    }
        //    Console.WriteLine("\n Item found in :"+ program.BinarySearhInAnArray(sortedarray,4));
           
            //Printing items in Queue
            //program.QueuePrintString("Happy New Year with Queue");
#endregion
           
           //searching a string within a string
           //program.searchsubstringwithinstring();
           
           //practice program
           program.PracticeTests("wooow");
           program.PracticeTests("pavan");
           program.PracticeTests("10000001");
           Console.WriteLine("\n");
           Console.ReadLine();
        }

        public void PracticeTests(string str)
        {
            Console.WriteLine("Given string is Palindrome or NOT :"+str+"\n");
            string left=null,right=null;
            int mid;

            if(!string.IsNullOrEmpty(str))
            {
                mid=str.Length/2;
                if(str.Length%2==0)
                {
                    left=str.Substring(0,mid);
                    right=str.Substring(mid,str.Length-mid);
                }
                else
                {
                    left=str.Substring(0,mid+1);
                    right=str.Substring(mid+1,(str.Length-(mid+1)));
                }

                Console.WriteLine("Left value : "+left);
                Console.WriteLine("right value: "+right);
                Console.WriteLine("reverse right value : " + reversegivenstring(right));

                if(left==reversegivenstring(right))
                {
                    Console.WriteLine("given string is palindrome \n");
                }
                else{Console.WriteLine("given string is NOT palindrome \n");}
            }
           
        }
        public string reversegivenstring(string str)
        {
            //Console.WriteLine("given string for reverse : "+str);
            string tempstr=null;
           
            if(!string.IsNullOrEmpty(str))
            {
               // Console.WriteLine("reverse string is processing");
                
                for(int i=str.Length-1;i>=0;i--)
                {
                    tempstr+=str[i];
                }
            }
           // Console.WriteLine("printing modified reverse string"+tempstr);
            return tempstr;
        }

        public void basicdotnetexample()
        {

            Console.WriteLine("\n");
            string fname,lname;
            Console.Write("Enter User First Name : ");
            fname=Console.ReadLine();
            Console.Write("Enter User Last Name : ");
            lname=Console.ReadLine();

            Console.WriteLine("first name and last name of User are : "+fname+" "+lname+"\n");
        }

        public void fuzzbuzzmethod(string usernumber)
        {
            Console.WriteLine("\n");
            if(int.TryParse(usernumber, out int num))
            {
                for(int i=0;i<int.Parse(usernumber);i++)
                {
                   // Console.WriteLine(i.ToString()+"/3"+(i%3).ToString());
                  //  Console.WriteLine(i.ToString()+"/5"+(i%5).ToString());
                    if(i%3==0 && i%5==0){Console.WriteLine("Fuzz..Buzz...");}else
                    if(i%3==0){Console.WriteLine("fuzz..");}else
                    if(i%5==0){Console.WriteLine("buzz..");}else
                    Console.WriteLine(i);
                }
                Console.WriteLine("\n thank you for fun program :) ");
            }

        }

        public void reversestring(string reversestring)
        {
            Console.WriteLine("\n Actual string is : "+reversestring);

            Console.WriteLine("Processing Reverse string");

            for(int i=reversestring.Length-1;i>=0;i--)
            {
                Console.Write(reversestring[i].ToString());
            }

            Console.WriteLine("\n\n Reverse string is completed.");
        }

        public void printnumberprymaid(int prymidlayers)
        {
            Console.WriteLine("printing prymaid \n");

            for(int i=0;i<prymidlayers;i++)
            {
                for(int k=0;k<prymidlayers-i;k++)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<i;j++)
                {
                    Console.Write("*");
                }
                for(int j=i;j>0;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }

        public void PrintCharactercount(string str)
        {
            if(str!=null && str.Length>0)
            {
                bool duplicate=false;
                string ustr=null;
                //collect unique characters
                for(int i=0;i<str.Length;i++)
                {
                    if(ustr==null){ustr=str[i].ToString();}
                    else{
                        for(int j=0;j<ustr.Length;j++)
                        {
                            if(ustr[j]==str[i]){duplicate=true;break;}
                        }
                        if(!duplicate){ustr+=str[i].ToString();}
                        }
                }
                    //count unique characters
                    if(ustr!=null)
                    {
                        for(int k=0;k<ustr.Length;k++)
                        {
                            int count=0;
                            for(int j=0;j<str.Length;j++)
                            {
                                if(ustr[k]==str[j])
                                {count+=1;}
                            }
                            Console.Write("character selected:"+ustr[k].ToString());
                            Console.Write("   -  number of characters :"+count.ToString()+"\n");
                        }
                    }
                }
        }

        public void PrintRepeatedCharacterAndCount(string str)
        {

            Console.WriteLine("given string is :"+str);

            Dictionary<string, int> repeatedchar=new Dictionary<string, int>();
            //clean string by converting everything into lower case
            str = Regex.Replace(str,@"[^a-zA-Z0-9]","");

            //setting count of each str character
            for(int i=0;i<str.Length;i++)
            {
               if(repeatedchar.ContainsKey(str[i].ToString())){
                        repeatedchar[str[i].ToString()]=repeatedchar[str[i].ToString()]+1;
                }
                else
                {
                    repeatedchar.TryAdd(str[i].ToString(),1);
                }
            }

            //print dictionary
            foreach(KeyValuePair<string, int> charcount in repeatedchar)
            {
                if(charcount.Value>1)
                {Console.WriteLine("character : "+charcount.Key+" value :"+charcount.Value);}
            }
        }

        public void BalancePraenthesis(string str)
        {
            //Balance paraenthesis using Stack object in C#
            //example [{()}] - is good , [({)}] - unbalanced, [(] - unbalanced

            string parastr= str;//"[{(a-b)}]";

            Console.WriteLine("\n Original string : "+parastr);
            //clean string:
            parastr=Regex.Replace(parastr.ToString().ToLower(),"[a-z0-9-]","");
            Console.WriteLine("\n Clean String with only paraenthises "+parastr);

            //use stack to find parathenises balances
            Stack<string> parastack=new Stack<string>();
            for(int i=0;i<parastr.Length;i++)
            {
                if(i==0){parastack.Push(parastr[i].ToString());}
                else {
                if(getClosingTag(parastack.Peek())==parastr[i].ToString())
                    {
                       // Console.WriteLine("balance equl close tag: "+getClosingTag(parastack.Peek()));
                        //Console.WriteLine("poped value : "+parastr[i].ToString());
                        parastack.Pop();

                        if(parastack.Count>0){ Console.WriteLine("the new peek item : "+parastack.Peek());}
                    }
                else{
                        Console.WriteLine("pushed value : "+parastr[i].ToString());
                        parastack.Push(parastr[i].ToString());
                    }
                }
            }

            if(parastack.Count==0)
            {
                Console.WriteLine("given string is Balanced");
                }
            else{
                Console.WriteLine("given string is not balanced , unbalanced string is : "+parastack.Peek());
                }
        }

        private string getClosingTag(string str)
        {

            switch(str)
            {
                case "[":
                    return "]";
                case "{":
                    return "}";
                case "(":
                    return ")";
            }
            return str;
        }

        public void reversestringusingstack(string str)
        {
            string revstr=null;
            if(str.Length>0)
            {
                Console.WriteLine("original string :"+str);
                Stack<string> originalstring=new Stack<string>();
                //pushing to stack all char
                for(int i=0;i<str.Length;i++){
                    originalstring.Push(str[i].ToString());
                }

                //printing in reverse order
                Console.WriteLine("Reverse String: ");
                for(int i=0;i<str.Length;i++){
                    revstr=revstr+originalstring.Peek();
                    originalstring.Pop();
                }

                Console.WriteLine("Reversed string is printed... "+revstr);

            }
            else{ Console.WriteLine("no string avaliabel to reverse");}

            //check palindrome
            if(str==revstr)
            {Console.WriteLine("the given string is palindrome");}
            else{ Console.Write("the given string is NOT palindrome");}

        }

        public void findingFirstUniqueCharUsingIndexOf(string str)
        {
            Console.WriteLine("Original String : "+str);
            if(str.Length>0)
            {
                for(int i=0;i<str.Length;i++)
                {
                    if(str.IndexOf(str[i])==str.LastIndexOf(str[i]))
                    {
                        Console.WriteLine("first unique character within given string is "+str[i].ToString());
                        break;
                    }
                }
            }
            else{Console.WriteLine("no string avaliable to find unique value");}
        }

        public void traversematrix()
        {

            int[,] matrix=new int[3,3];
            //sample array 3x3
            matrix[0,0]=1;
            matrix[0,1]=2;
            matrix[0,2]=3;

            matrix[1,0]=4;
            matrix[1,1]=5;
            matrix[1,2]=6;

            matrix[2,0]=7;
            matrix[2,1]=8;
            matrix[2,2]=9;


            int n=matrix.Length;

            Console.WriteLine("matrix size :"+n.ToString());
            //print matrix
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine("\n");
            }

            //matrix[3][3]= [[1,2,3],[4,5,6],[7,8,9]];
            //Flip horizontal to vertical - step 1
            n=3;

            Console.WriteLine("printing reverse matrix");
            //swap horizontal to vertical
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    
                if(i!=j){
                   int temp=matrix[i,j];
                   matrix[i,j]=matrix[j,i];
                   matrix[j,i]=temp;
                }

                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine("\n");
            }


            // Console.WriteLine("reverse (horizontal to veritical) matrix 3x3 :");
            //  //print matrix
            // for(int i=0;i<n;i++)
            // {
            //     for(int j=0;j<n;j++)
            //     {
            //         Console.Write(matrix[i,j]+" ");
            //     }
            //     Console.WriteLine("\n");
            // }

            // // step 2 flip horizontal
            // for(int i=0;i<n;i++)
            // {
            //     for(int j=i;j<n/2;j++)
            //     {
            //         int temp=matrix[i,j];
            //         matrix[i,j]=matrix[i,n-1-j];
            //         matrix[i,n-1-j]=temp;
            //     }
            // }

            //  Console.WriteLine("90 degree reverse matrix 3x3 :");
            //   //print matrix
            // for(int i=0;i<3;i++)
            // {
            //     for(int j=0;j<3;j++)
            //     {
            //         Console.Write(matrix[i,j]+" ");
            //     }
            //     Console.WriteLine("\n");
            // }
        }
    
        public void Find_the_missing_number_in_the_array()
        {
            // int[] inputarr=new int[5];
            // inputarr[0]=1;
            // inputarr[1]=2;
            // inputarr[2]=3;
            // inputarr[3]=4;
            // inputarr[4]=6;

            List<int> inputarr=new List<int>(){1,2,4,6,8};
            inputarr.Sort();

            if(inputarr.Count>0){
                for(int i=0;i<inputarr.Count-1;i++)
                {
                    if(inputarr[i+1]!=inputarr[i]+1){Console.WriteLine("missing number :"+(inputarr[i]+1));}
                }
            }
        }
    
        public void Find_sumof_Two_Values_EqualsTo()
        {
            int[] num=new int[]{2,3,4,5,7,8,9,3};
            int sumequalto=10;
            var matchedvalues=new Dictionary<string,string>();
            var calcvalues =new HashSet<string>();

            Console.WriteLine("performing sum of 2 values in a given array");
            if(num.Length>0)
            {

                // Default process    
                for(int i=0;i<num.Length-1;i++)
                {
                    for(int j=0;j<num.Length-1;j++)
                    {
                        if(i!=j){
                            if(num[i]+num[j]==sumequalto)
                            {
                                matchedvalues.Add(num[i].ToString(),"printing combinations: "+num[i]+" and "+num[j]);
                                //Console.WriteLine("printing combinations: "+num[i]+" and "+num[j]);
                            }
                        }
                    }
                }
                if(matchedvalues.Count>0){
                foreach(KeyValuePair<string,string> match in matchedvalues)
                {
                    Console.WriteLine(match.Value);
                }
                }
                else{ Console.WriteLine("no values in given string is not summing up to : "+sumequalto);}
                
                //Try 2 - substract total with first element and check the result value avaliable within array , if so, then matching

                for(int i=0;i<num.Length;i++)
                {
                    calcvalues.Add((sumequalto- num[i]).ToString());
                }

                // foreach(var calval in calcvalues)
                // {
                //     Console.WriteLine(" value uploaded to hashset are :"+calval.ToString());
                // }
                for(int i=0;i<num.Length;i++)
                {
                    if(calcvalues.Contains(num[i].ToString())){
                        Console.WriteLine("pair found :"+(sumequalto-num[i]).ToString()+" and "+num[i].ToString());
                    }
                }               
            }
        }
    
        public int BinarySearhInAnArray(int[] array,int elementfind)
        {
            //Binary search is a process finding element within array using sorted path
        
            //consider given array has sorted elements
            
            int left=0;
            int right=array.Length;

            while(left<right)
            {
                int mid=(left+right)/2;
                if(array[mid]==elementfind){ return mid;}
                else
                {
                    if(array[mid]>elementfind)
                    {
                        right=mid;
                    }
                    else{
                        left=mid+1;
                    }
                }
            }
            return -1;
        }
    
        public void QueuePrintString(string str)
        {
            Queue<string> strq=new Queue<string>();
            
            for(int i=0;i<str.Length;i++)
            {
                strq.Enqueue(str[i].ToString());
            }

            //print queue values
            foreach(var qitem in strq)
            {
                Console.Write(qitem);
            }

            //display count of queue items
            Console.WriteLine("Number of items in queue  are: {0}",strq.Count);

            //display peek of element in queue
            Console.WriteLine("peek element in queue {0} .",strq.Peek());

            //dequeue items in strq
            while(strq.Count>0)
                Console.WriteLine("Element taken out from queue is {0}",strq.Dequeue());

            //display count of queue items after removal
            Console.WriteLine("Number of items in queue after after removal: {0}",strq.Count);
        }

        public void searchsubstringwithinstring()
        {
            string hairstack="aaaaaabbbbaaaabcasdfasdfsabcasdfasdfwerwerwer";
            string needle="b";

            List<int> occurances=new List<int>();

            //logic to find subsctring within big string.
            // search first char of needle within hairstack and grep the next 2 letters and see if could find match

            if(needle.Length>hairstack.Length || string.IsNullOrEmpty(needle)|| string.IsNullOrEmpty(hairstack))
            {
                Console.WriteLine("unable to search, because the source has less characters");
                return;
            }

            //working solution with dictonary - this is long process and use lot of resource
            //working solution with regular
            Console.WriteLine("searching needle in hairstack, where hairstack is {0} and needle is {1}",hairstack,needle);
        
            for(int i=0;i<hairstack.Length;i++)
            {
                // Console.WriteLine("within loop");
                if(needle[0] == hairstack[i])
                {
                   // Console.WriteLine("matched first letter in both");
                    if(needle==hairstack.Substring(i,needle.Length)){occurances.Add(i);}
                }
            }

            Console.WriteLine("printing values of search results");
            foreach(var item in occurances)
            {
                Console.WriteLine("needle found @ {0}",item);
            }

        }
    }
}
