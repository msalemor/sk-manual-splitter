default:
	@echo "Do something"

clean:
	rm -rf src/backend/wwwroot
	mkdir src/backend/wwwroot

build-ui: clean
	@echo "Build UI"
	cd src/frontend && npm run build
	cp -r src/frontend/dist/* src/backend/wwwroot

run: build-ui
	@echo "Run"
	cd src/backend && dotnet watch run

docker: build-ui
	@echo "Docker"
	cd src/backend && docker build . -t am8850/tokensplitter:dev

docker-run: docker
	@echo "Docker run"
	docker run --rm -p 8080:80 am8850/tokensplitter:dev

docker-push: docker
	docker push am8850/tokensplitter:dev