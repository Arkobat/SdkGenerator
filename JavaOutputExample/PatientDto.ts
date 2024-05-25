package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class PatientDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private HospitalDto Hospital;
        @Nullable
    	private MedicalRecordDto MedicalRecords;
    
    
    
}