#official documentation: https://docs.python.org/3/tutorial/index.html
#Better documentation: https://www.w3schools.com/python/default.asp
#file extention : .py
#import libraries using "import libraryname"

#Tabbing in python does matter
"""
Quotation marks can be used as multiline comments,
However it is just a multiline string
"""
def main(): #is not run automatically

    #Console Commands
    input = input() #Gets user input from console
    print(input)    #Prints line
    
    #Variables
    #ints
    int = 1
    #floats
    floats = 1.2
    #strings
    string = "string"
    #booleans
    booleans1 = True
    booleans2 = False
    #arrays
    list = [[1,2],2,3,4]
    """
    print list          # Prints complete list
    print list[0]       # Prints first element of the list
    print list[1:3]     # Prints elements starting from 2nd till 3rd
    print list[2:]      # Prints elements starting from 3rd element
    """
    #Tuples, read only lists
    tuple = (1,2,3)
    #variables that are created in functions/objects are local, unless you use the global keyword

    #Math
    #Addition
    1+1
    #subtraction
    2-2
    #Multiplication
    2*2
    #Division
    1/2 #regular division returns a float
    1//2 #floor division, returns 0
    #Powers
    1**2
    #variables can quickly be operated and resigned by adding an equal signs afterwards
    int = 1
    int += 1


# If statements
if True == True:
    pass
elif False != True:
    pass
else:
    pass


#For Loops
#for loops can iterate though lists,strings,ranges,etc
fruits = ["apple", "banana", "cherry"]
for x in fruits:
  print(x)

for x in range(0,5):
    print(x)

# While Loops
while True:
    break #ends loop
    continue #ends current iteration, but continues the loop


#functions
def AFunction(a = "A"): #Creates a function, a's default value is "A"
    print(a)
    return a
    pass #ends an empty function

#Classes
class MyClass(): #if inheritance is wanted put parent class in the ()
    varint = 3
    def __init__(self): # called upon initiation of an object
        self.variable = 2 #creates a local variable

class TheirClass(MyClass):
  def __init__(self, fname, lname): # recreating functions overrides parent's methods
    MyClass.__init__(self) # you can recall parent functions like this

#Iterators
myIter = iter(fruits) #Lists, tuples, dictionaries, and sets can be turned into Iterators

print(next(myIter)) #banana
print(next(myIter)) #cherry
print(next(myIter)) #Apple
