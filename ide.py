# Parameters:
name = "Monica Cue"
hobbies = []
proffesion = []
proffesion.append("Data Scientist")
proffesion.append("AI Developer")
hobbies.append("Play chess")
hobbies.append("Reading books")
hobbies.append("Learn new things")
age = 18
country = "Mexico"
code_age = 9

# Function:
def introduce_myself(name, age, country, proffesion, hobbies, code_age):
    print(f"Hi my name is {name}, I'm {age} years old, and I'm from {country}.")
    print(f"I learn to code at the age of {code_age}.")
    print(f"Now I'm a {proffesion[0]} and an {proffesion[1]}.")
    print("Some of my hobbies are: ")
    for i in range(len(hobbies)):
        print("     " + str(i)+ ". " + hobbies[i])

introduce_myself(name, age, country, proffesion, hobbies, code_age)
