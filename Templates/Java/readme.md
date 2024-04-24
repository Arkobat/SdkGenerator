# How to create DTOs with Java

## Prerequisites
You must have Java and Maven installed.
To validate this, run `mvn -v` and `java -version`

## Step by step guide
1) Check out the project `git clone git@github.com:Arkobat/SdkGenerator.git`
2) Navigate to this folder `cd .\SdkGenerator\Templates\Java\`
3) Install the dependencies `mvn install`
4) Open the project in your desired IDE, and create the files needed
   - You are free to create both folders and files as pleases you
   - This is an example DTO, you can take inspiration from.
```typescript
package sdk;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

public class ExampleDto {

   @NotNull
   @SerializedName("name")
   private String name;

   @SerializedName("version")
   private int version;

   @Nullable
   @SerializedName("childNode")
   private String childNode;

   @Nullable
   @SerializedName("parentNode")
   private String parentNode;


   public @NotNull String getName() {
      return name;
   }

   public int getVersion() {
      return version;
   }

   public @Nullable String getChildNode() {
      return childNode;
   }

   public @Nullable String getParentNode() {
      return parentNode;
   }

}
```
5) Build the project with `mvn package`
6) Now you are done