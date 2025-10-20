Here is the link to my youtube video demo:

https://youtu.be/chNxyz4ofvY
https://youtu.be/chNxyz4ofvY


Changes Based on Lecturer Feedback
The following improvements were made during the development of Part 2, directly addressing the feedback received on the Part 1 submission.
1. Version Control & Commit History
Feedback: "Commit is infrequent, and commit messages lack clarity or description of changes."
Improvement Made:
During the active development phase in Part 2, a disciplined version control strategy was adopted. Commits were made frequently at the completion of each significant feature or logical unit of work (e.g., "Implement Claims Controller and CRUD views," "Add status tracking for claims (Pending/Approved/Rejected)," "Integrate lecturer selection dropdown in claim creation form"). This resulted in a detailed and descriptive commit history that accurately reflects the project's development timeline and the nature of the changes made.
2. Enhanced Design & Implementation
Feedback: "The rationale behind design decisions is reasonable but may lack some depth or coherence."
Improvement Made:
The initial design choices from Part 1 were rigorously validated and refined during implementation.
Database Structure: The final database schema, implemented using Entity Framework Core, is robust and tailored to the domain of salary claims. The system now fully captures all necessary entities, including Lecturer details (name, department, employee ID), Claim items (date, type, description, amount), and the claim's status throughout its workflow. The relationships between lecturers and their multiple claims are correctly enforced as a one-to-many relationship in the DbContext.
Class Diagram Accuracy: The initial class diagram was used as a blueprint and was refined during development. The final, implemented data models are a more complete and accurate representation of the system's requirements. For example, the Claim model was expanded with specific properties like Status, SubmissionDate, and ApprovedDate to fully track the claim lifecycle, resolving any previous omissions.
3. Improved GUI Usability and Layout
Feedback: "The GUI design is somewhat user-friendly and intuitive, with adequate layout and usability but room for improvement."
Improvement Made:
The GUI was significantly enhanced beyond the initial wireframes to create a more polished and user-friendly experience specific to managing claims.
Layout: A consistent and professional layout template was applied across all views, featuring a clear navigation menu for easy access to "Lecturers," "All Claims," and "New Claim" sections.
User Experience (UX): The claims list is presented in a clean, styled table with clear column headings (Claim ID, Lecturer Name, Date, Amount, Status). The status is visually distinct (e.g., using coloured badges). Forms for submitting new claims are intuitive, using dropdowns to select the lecturer and claim type, date pickers, and clear input validation. Action buttons (Submit, Save, Cancel) are prominent, and confirmation messages provide feedback upon successful actions.
Summary of Enhancements
Part 1 Feedback Area
Part 2 Implementation & Improvement
Infrequent Commits
Adopted a frequent, feature-driven commit strategy with clear, descriptive messages.
Design Depth
Validated and refined the design into a complete schema for managing lecturers and their salary claims.
Class Diagram
Evolved the diagram into accurate code models, fully capturing the claim lifecycle and status tracking.






