package com.example.demo;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {

	@GetMapping(value = "/")
	private String index() {
		return "アクセス成功です";
	}
	
	@GetMapping(value = "/hello")
	private String hello() {
		return "Hello World!";
	}
	
	@GetMapping(value = "/welcome")
	private String welcome() {
		return "Spring Bootへようこそ";
	}
}
