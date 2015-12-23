# VNext Skeleton

This is just a starter application to use to bootstrap development of an ASP VNext application.
The standard yeoman templates don't go far enough in setting up a real-world solution.  So,
this aims to capture most of that setup.  What we get out of the box here is a simple solution
with 2 projects - one Web API project, and one domain class library.  These have appropriate
references set up, and dependency injection is used to establish the dependency to the domain.
Furthermore, logging is wired in using Serilog, and injected into the classes.

* JD.Skeleton.Api - The API REST service.
* JD.Skeleton.Domain - The business logic layer and models for the skeleton application.
