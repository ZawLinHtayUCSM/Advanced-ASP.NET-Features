# Custom CORS policy Attribute

# Steps to implement
 	Step 1: Enable CORS in WebApiConfig.cs
	Step 2: Add a new class based on Attribute, ICorsPolicyProvider ( public class CustomCorsPolicyAttribute : Attribute, ICorsPolicyProvider)
 	Step 3: Add CustomCors Attribute to Controllers
	Step 4: Test.

# Endpoint to test
http://localhost:55319/api/students

