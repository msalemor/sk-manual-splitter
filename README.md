# Tokenizer -Text Splitting and Token Counter Tool

This tool will can split text using several methods and then count the resulting tokens from each of the sections. Use it to analyze the effect of splitting the large chunks of text for ingestion, maybe in a RAG pattern solution, and to find the optimal settings based on your content.

The splitting methods are by:

- Semantic Kernel's splitter
- Paragraph simple
- Paragraph/Words

## `Frontend`

- SolidJS
- Tailwind CSS

## `Backend`

- .NET 7 WebAPI Minimal API also serving static files
- Semantic Kernel

## Running the app

- Clone the repo

### Running locally

Type: `make run`

## Running as a Docker container

Type: `make docker-run`

**Note:** If you are not familiar with make, just open the `Makefile` and copy and execute the commands in a shell.
