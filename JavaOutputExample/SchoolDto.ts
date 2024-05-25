package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class SchoolDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private AddressDto Address;
        @Nullable
    	private EnrollmentDto Enrollments;
        @Nullable
    	private CourseDto Courses;
    
    
    
}