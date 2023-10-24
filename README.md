# MobilunityTestTask

Below is data model object that describes Categories and Sub Categories  - unlimited levels 


1. CategoryId

2. CategoryName

3. ParentCategoryId


Test Tasks - 


1. Create C# server side code to return the above data model to the page - add some sample data of categories and sub categories with at least 3 levels (to clarify - the hard coded data is just sample - while the code should support unlimited subcategories level, and by levels I mean each subcategory can have another subcategory inside and on on and on)


data for example (its s short example - more data is needed to create 3 levels)


[

{

    CategoryId = 1,

    CategoryName = "Fruits",

    ParentCategoryId = null

},

{

    CategoryId = 2,

    CategoryName = "Apples",

    ParentCategoryId = 1

}

]


2. Create Angular page to present this data using this component -https://material.angular.io/components/tree/overview


IMPORTANT NOTE - main point of the task is to convert in efficient way from the above data structure to the tree data structure requires by the material tree component 


Required tools to prepare before the meeting - 


Developer tools for building Angular page +  C# server side"

Angular Material
https://material.angular.io


3. SQL short question as follows - plan note the answer should be in SQL syntax not in C#:

You have 2 tables : Sales , and SalesDetails .
Table Sales fields :
SaleID, SaleDate, BuyerEmail.
Table SalesDetails fields :
SaleID,ProductID,ProductName,ProductQuantity,ProductPrice.

Question:  I want to get all the emails of the buyers that their average daily total payment amount is over 1000.
![image](https://github.com/RudeBit4/MobilunityTestTask/assets/32190378/6fc18ff0-e962-4e23-8815-c9a960104932)
