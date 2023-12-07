﻿shader"holes/depth mask" {
	subshader {
		// очередь должа стоять после объектов которые смогут опускаться в дырку (шар,
		// дыра-цилиндр), но перед теми в которых мы хотим выколоть дыру (стол) 
		tags { "queue" = "geometry-1" }
 
		// не рисовать никаких цветов, только z-буфер
 		colormask 0
		// zwrite on
 
		// во время прохода ничего не делаем 
		pass {}
	}
}
