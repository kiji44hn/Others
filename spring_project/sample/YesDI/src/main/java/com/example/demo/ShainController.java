package com.example.demo;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class ShainController {
	
	private final ShainService shainService;

	//ShainServiceのDI
	public ShainController(ShainService shainService) {
	this.shainService = shainService;
	}

	@RequestMapping("/input")
	public String index(ShainForm shainform) {
		return "index.html";
	}

	@RequestMapping("/output")
	public String result(@Validated ShainForm shainForm,
			BindingResult bindingResult, Model model) {
		if (bindingResult.hasErrors()) {
			return "index.html";
		}

		//String name = "コントローラー太郎";
		//サービス層から社員を検索
		String name = shainService.findByNo(shainForm.getNumber());
		
		model.addAttribute("number", shainForm.getNumber());
		model.addAttribute("name", name);
		return "output.html";
	}

}