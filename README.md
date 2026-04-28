# CSC360-FinalProject
## Temple Run


This is my clone of temple run. 

## Software Designs Implemented

### Singleton - ``` GameManager ```



GameManager in this project makes sure that every class can call GetInstance statically. If the Instance is null, it will find the GameManager component. Otherwise it returns the private instance variable.
This makes sense so I am able to reference the same instance of the GameManager.
