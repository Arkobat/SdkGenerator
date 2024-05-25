package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class SkillDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @Nullable
    	private String Proficiency;
        @Nullable
    	private CertificationDto Certifications;
        @Nullable
    	private ExperienceDto Experience;
    
    
    
}