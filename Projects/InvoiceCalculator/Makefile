SHELL := /bin/bash

.PHONY: help
help:
	@printf "available targets -->\n\n"
	@cat Makefile | grep ".PHONY" | grep -v ".PHONY: _" | sed 's/.PHONY: //g'


.PHONY: clitest
clitest:
	csc InvoiceCalculator.cs InvoiceCalculatorTest.cs
	mono InvoiceCalculatorTest.exe


.PHONY: container
container: clitest
	docker build . -t my-first-c-sharp-container


.PHONY: run
run: container
	docker run -p 8080:8080 -i -t my-first-c-sharp-container


.PHONY: open-web
open-web:
	open "http://localhost:8080/vnc_lite.html"
