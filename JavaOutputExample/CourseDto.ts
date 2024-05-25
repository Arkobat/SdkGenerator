package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class CourseDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private SchoolDto School;
        @NotNull
    	private TranscriptDto Transcript;
        @Nullable
    	private EnrollmentDto Enrollments;
    
    
    
}