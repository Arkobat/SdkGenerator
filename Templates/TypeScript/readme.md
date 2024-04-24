# How to create DTOs with TypeScript

## Prerequisites
You must have NPM installed.
To validate this, run `npm -v`

## Step by step guide
1) Check out the project `git clone git@github.com:Arkobat/SdkGenerator.git`
2) Navigate to this folder `cd .\SdkGenerator\Templates\TypeScript\`
3) Install the dependencies `npm install`
4) Open the project in your desired IDE, and create the files needed
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
5) Once every file has been generated, run `npm run generate-barrels` to generate SDK.
6) Now you are done