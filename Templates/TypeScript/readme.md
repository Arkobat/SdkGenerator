# How to create DTOs with TypeScript

## Prerequisites
You must have NPM installed.
To validate this, run `npm -v`

## Step by step guide
1) Check out the project `git clone git@github.com:Arkobat/SdkGenerator.git`
2) Navigate to this folder `cd .\SdkGenerator\Templates\TypeScript\`
3) Create a new branch for your changes `git swtich -c <branch_name>`. Replace `<branch_name>` with something unique, e.g. your GitHub username.
4) Install the dependencies `npm install`
5) Open the project in your desired IDE, and create the files needed
   - You are free to create both folders and files as pleases you
   - This is an example DTO, you can take inspiration from.
```typescript
export interface ExampleDto {
    name: string;
    version: number;
    childNode?: ExampleDto;
    parentNode: ExampleDto | undefined;
}
```
6) Once every file has been generated, run `npm run generate-barrels` to generate SDK.
7) Commit and push the files `git commit -am "Creates DTOs" && git push`
8) Now you are done