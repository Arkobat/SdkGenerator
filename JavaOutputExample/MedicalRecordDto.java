/**
* Auto generated class
*/
 
package SchemaExtractor.Model.Example;
import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

public class MedicalRecordDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Description;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private PersonDto Patient;
        @NotNull
    	private DoctorDto Doctor;
        @Nullable
    	private PrescriptionDto Prescriptions;
        @Nullable
    	private InsuranceClaimDto InsuranceClaim;
        @Nullable
    	private BenefitDto Benefit;
    
    
    
}