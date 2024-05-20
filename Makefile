test:
	dotnet test --no-build -p:CollectCoverage=true -p:CoverletOutputFormat=lcov -p:CoverletOutput=coverage/

publish:
	make clean && dotnet pack -c Release

clean:
	dotnet clean
csharp:
	rm -rf /docs && \
	rm -rf src/DigitalFemsa.net/Model && \
	docker run --rm \
	-v ${PWD}:/local openapitools/openapi-generator-cli:v7.5.0 generate \
    -i https://raw.githubusercontent.com/digitalfemsa/openapi/main/_build/api.yaml \
    -g csharp \
    -o /local \
    -c /local/config-netcore.json \
    --global-property modelTests=true