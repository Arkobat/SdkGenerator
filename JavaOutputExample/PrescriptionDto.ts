package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class PrescriptionDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Medication;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private DoctorDto Doctor;
        @NotNull
    	private PersonDto Patient;
    
    
    
}