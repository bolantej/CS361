To request data from the microservice:
  1. First find the port the service is being run, you can do this by running the program
![The port is shown as 5000](/microservice/images/showingport.png)
  2. Now you can make a call to the microservice using the api endpoint: /food/<food_name> where <food_name> is the name of the food you want to search for
     Example: If the microservice is running on port 5000, you could search for the calories of a steak using http://localhost:5000/food/steak
  3. If you want to search for a food that is multiple words, you can use either "%20" or "_" as a replacement for the space in the url.
     Example: http://localhost:5000/food/cheddar_cheese or http://localhost:5000/food/cheddar%20cheese

To receive data from the microservice:
  1. The program will send back a response with the number of calories in the requested food
![The response shows there are 556 calories in steak](/microservice/images/response.png)


UML Diagram:
![UML Diagram](/microservice/images/diagram.png)
