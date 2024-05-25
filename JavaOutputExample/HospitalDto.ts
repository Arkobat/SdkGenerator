package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class HospitalDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private AddressDto Address;
        @Nullable
    	private DoctorDto Doctors;
        @Nullable
    	private PatientDto Patients;
    
    
    
}