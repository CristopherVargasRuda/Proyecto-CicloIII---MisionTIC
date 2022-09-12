--------- Agregar Auxiliares ------------

INSERT INTO dbo.Auxiliar VALUES (123456789, 'a123', 'Miguel', 'Algo', 'Otro Algo', 'Y otro algo', '2005-05-05', '12345444');
INSERT INTO dbo.Auxiliar VALUES (1019123615, 'a123', 'Cristopher', NULL, 'Vargas', 'Ruda', '1996-09-24', '3196739737');
INSERT INTO dbo.Auxiliar VALUES (987987987, 'a123', 'William', 'David', 'Vargas', 'Pinto', '1995-05-05', '12345444');

--------- Agregar Socios_Empresa ------------

INSERT INTO dbo.Socio_empresa VALUES (789789, 's123', 'Alexander', 'David', 'Romero', 'Pinto', '1995-05-05', '12345444');
INSERT INTO dbo.Socio_empresa VALUES (456456, 's123', 'Laura', 'Tatiana', 'Fernandez', 'Perez', '1995-05-05', '12345444');

--------- Agregar Jefe_Operaciones ------------

INSERT INTO dbo.Jefe_operaciones VALUES (123123123, 'j123', 'Sebastian', 'Antonio', 'Beltran', 'Garavito', '1995-05-05', '12345444');
INSERT INTO dbo.Jefe_operaciones VALUES (321321321, 'j123', 'Cristian', 'Camilo', 'Niño', 'Rincón', '1995-05-05', '12345444');

--------- Agregar Tecnicos ------------

INSERT INTO dbo.Tecnico VALUES ('Calle 123 # 51 - 98', 'Técnico', 111111111, 't123', 'Augusto', 'Alfredo', 'Rojas', 'Hurtado', '1995-05-05', '12345444');
INSERT INTO dbo.Tecnico VALUES ('Calle 123 # 51 - 98', 'Técnico', 222222222, 't123', 'William', 'Yecid', 'Castellanos', 'Rincón', '1995-05-05', '12345444');

--------- Agregar Operarios ------------

INSERT INTO dbo.Operario VALUES (444444444, 'o123', 'Catalina', 'Alvarado', 'Beltran', 'Garavito', '1995-05-05', '12345444');
INSERT INTO dbo.Operario VALUES (555555555, 'o123', 'Angie', 'Tatiana', 'Niño', 'Rincón', '1995-05-05', '12345444');

--------- Agregar estados ------------

-- Impresora
INSERT INTO dbo.Estado VALUES ('Impresora - Perfectas Condiciones');
INSERT INTO dbo.Estado VALUES ('Impresora - Seguro Vencido');
INSERT INTO dbo.Estado VALUES ('Impresora - Dañado');
INSERT INTO dbo.Estado VALUES ('Impresora - Ocupado');
INSERT INTO dbo.Estado VALUES ('Impresora - Mantenimiento');
INSERT INTO dbo.Estado VALUES ('Impresora - Sin Software');
INSERT INTO dbo.Estado VALUES ('Impresora - Componente Dañado');


-- Software
INSERT INTO dbo.Estado VALUES ('Software - Correcto');
INSERT INTO dbo.Estado VALUES ('Software - Licencia vencida');

-- Componente
INSERT INTO dbo.Estado VALUES ('Cabezal - Correcto');
INSERT INTO dbo.Estado VALUES ('Cabezal - Defectuoso');
INSERT INTO dbo.Estado VALUES ('Cabezal - Proximo a cambiar');
INSERT INTO dbo.Estado VALUES ('Extrusor - Correcto');
INSERT INTO dbo.Estado VALUES ('Extrusor - Defectuoso');
INSERT INTO dbo.Estado VALUES ('Extrusor - Proximo a cambiar');
INSERT INTO dbo.Estado VALUES ('Cama Alineadora - Alineado');
INSERT INTO dbo.Estado VALUES ('Cama Alineadora - Desalineado');
INSERT INTO dbo.Estado VALUES ('Cama Alineadora - Flojo');
INSERT INTO dbo.Estado VALUES ('Fuente de Alimentación - Correcto');

--------- Agregar Componentes ------------

-- Cabezales
INSERT INTO dbo.Componente VALUES ('Cabezal 1', 'Parte superior de marca tales y que tal');
INSERT INTO dbo.Componente VALUES ('Cabezal 2', 'Parte superior de marca tales y que tal');
INSERT INTO dbo.Componente VALUES ('Cabezal 3', 'Parte superior de marca tales y que tal');
INSERT INTO dbo.Componente VALUES ('Cabezal 4', 'Parte superior de marca tales y que tal');

-- Extrusor
INSERT INTO dbo.Componente VALUES ('Extrusor 1','Aparato que Extrusa');
INSERT INTO dbo.Componente VALUES ('Extrusor 2','Aparato que Extrusa');
INSERT INTO dbo.Componente VALUES ('Extrusor 3','Aparato que Extrusa');
INSERT INTO dbo.Componente VALUES ('Extrusor 4','Aparato que Extrusa');
INSERT INTO dbo.Componente VALUES ('Extrusor 5','Aparato que Extrusa');

-- Fuentes de alimentación
INSERT INTO dbo.Componente VALUES ('Fuente de Alimentación 1', '30.5');
INSERT INTO dbo.Componente VALUES ('Fuente de Alimentación 2', '220.5');
INSERT INTO dbo.Componente VALUES ('Fuente de Alimentación 3', '120.5');
INSERT INTO dbo.Componente VALUES ('Fuente de Alimentación 4', '20.5');
INSERT INTO dbo.Componente VALUES ('Fuente de Alimentación 5', '100.5');

-- Camas alineadoras
INSERT INTO dbo.Componente VALUES ('Cama Alineadora 1','Cama que alínea');
INSERT INTO dbo.Componente VALUES ('Cama Alineadora 2','Cama que alínea');
INSERT INTO dbo.Componente VALUES ('Cama Alineadora 3','Cama que alínea');
INSERT INTO dbo.Componente VALUES ('Cama Alineadora 4','Cama que alínea');
INSERT INTO dbo.Componente VALUES ('Cama Alineadora 5','Cama que alínea');
INSERT INTO dbo.Componente VALUES ('Cama Alineadora 6','Cama que alínea');
INSERT INTO dbo.Componente VALUES ('Cama Alineadora 7','Cama que alínea');
INSERT INTO dbo.Componente VALUES ('Cama Alineadora 8','Cama que alínea');

--------- Agregar Tipo_Cubrimientos ------------

INSERT INTO dbo.Tipo_cubrimiento VALUES ('Robo', 'Cuando se roban la impresora');
INSERT INTO dbo.Tipo_cubrimiento VALUES ('Calamidades', 'Cuando la impresora le pasa algo calamidoso');
INSERT INTO dbo.Tipo_cubrimiento VALUES ('Contractual', 'Cuando la impresora le pasa algo contractual');
INSERT INTO dbo.Tipo_cubrimiento VALUES ('Extracontractual', 'Cuando la impresora le pasa algo extracontractual');

--------- Agregar Seguros ------------

INSERT INTO dbo.Seguro VALUES ('Seguro Clase A');
INSERT INTO dbo.Seguro VALUES ('Seguro Clase B');
INSERT INTO dbo.Seguro VALUES ('Seguro Clase C');
INSERT INTO dbo.Seguro VALUES ('Seguro Clase D');
INSERT INTO dbo.Seguro VALUES ('Seguro Clase E');
INSERT INTO dbo.Seguro VALUES ('Seguro - Robo');
INSERT INTO dbo.Seguro VALUES ('Seguro - Calamidades');
INSERT INTO dbo.Seguro VALUES ('Seguro - Contractual');
INSERT INTO dbo.Seguro VALUES ('Seguro - Extracontractual');

--------- Agregar Seguro_Tipo_Cubrimientos ------------

INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (1, 1);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (1, 2);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (1, 3);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (1, 4);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (2, 1);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (2, 2);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (2, 3);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (3, 1);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (3, 2);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (4, 3);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (4, 4);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (5, 2);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (5, 3);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (6, 1);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (7, 2);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (8, 3);
INSERT INTO dbo.Seguro_tipoCubrimiento VALUES (9, 4);

--------- Agregar Softwares ------------

INSERT INTO dbo.Software VALUES ('Software 1', '5.2.3', '123 456 789', 8);
INSERT INTO dbo.Software VALUES ('Software 2', '5.2.3', '123 456 789', 8);
INSERT INTO dbo.Software VALUES ('Software 3', '5.2.3', '123 456 789', 8);
INSERT INTO dbo.Software VALUES ('Software 4', '5.2.3', '123 456 789', 8);


--------- Agregar Impresoras ------------

INSERT INTO dbo.Impresora VALUES ('SLM1946', 'Cartesina', 'Adidas', 2022, 25, 40, 45, 50, 'Colombia', 1, 1, 1, 1);
INSERT INTO dbo.Impresora VALUES ('CDLM1946', 'Polar', 'Adidas', 2020, 25, 40, 45, 50, 'Colombia', 1, 2, 1, 1);

--------- Agregar Componentes ------------

INSERT INTO dbo.Impresora_componente VALUES (1, 1, 10);
INSERT INTO dbo.Impresora_componente VALUES (1, 5, 13);
INSERT INTO dbo.Impresora_componente VALUES (1, 10, 19);
INSERT INTO dbo.Impresora_componente VALUES (1, 15, 16);
INSERT INTO dbo.Impresora_componente VALUES (2, 2, 10);
INSERT INTO dbo.Impresora_componente VALUES (2, 6, 13);
INSERT INTO dbo.Impresora_componente VALUES (2, 11, 19);
INSERT INTO dbo.Impresora_componente VALUES (2, 16, 16);

--------- Agregar Componentes ------------

INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 1, 1, 1);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 1, 2, 1);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 1, 3, 2);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 1, 4, 2);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 2, 1, 1);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 2, 2, 1);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 2, 3, 2);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 2, 4, 2);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 2, 1, 1);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 2, 2, 1);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 2, 3, 2);
INSERT INTO dbo.Servicio_Tecnico VALUES ('2022-05-05', 2, 4, 2);

--------- Agregar Mantenimiento_Componente ------------

INSERT INTO dbo.Mantenimiento_componente VALUES (1, 1);
INSERT INTO dbo.Mantenimiento_componente VALUES (1, 2);
INSERT INTO dbo.Mantenimiento_componente VALUES (1, 3);
INSERT INTO dbo.Mantenimiento_componente VALUES (1, 4);
INSERT INTO dbo.Mantenimiento_componente VALUES (2, 1);
INSERT INTO dbo.Mantenimiento_componente VALUES (2, 3);
INSERT INTO dbo.Mantenimiento_componente VALUES (2, 4);
INSERT INTO dbo.Mantenimiento_componente VALUES (3, 2);
INSERT INTO dbo.Mantenimiento_componente VALUES (3, 3);
INSERT INTO dbo.Mantenimiento_componente VALUES (3, 4);
INSERT INTO dbo.Mantenimiento_componente VALUES (6, 5);
INSERT INTO dbo.Mantenimiento_componente VALUES (6, 6);
INSERT INTO dbo.Mantenimiento_componente VALUES (6, 7);
INSERT INTO dbo.Mantenimiento_componente VALUES (6, 8);
INSERT INTO dbo.Mantenimiento_componente VALUES (7, 5);
INSERT INTO dbo.Mantenimiento_componente VALUES (7, 7);
INSERT INTO dbo.Mantenimiento_componente VALUES (7, 8);
INSERT INTO dbo.Mantenimiento_componente VALUES (8, 5);
INSERT INTO dbo.Mantenimiento_componente VALUES (8, 6);
INSERT INTO dbo.Mantenimiento_componente VALUES (9, 7);
INSERT INTO dbo.Mantenimiento_componente VALUES (9, 8);

--------- Agregar Cambio_Componente ------------

INSERT INTO dbo.Cambio_componente VALUES (1, 1);
INSERT INTO dbo.Cambio_componente VALUES (1, 2);
INSERT INTO dbo.Cambio_componente VALUES (1, 3);
INSERT INTO dbo.Cambio_componente VALUES (1, 4);
INSERT INTO dbo.Cambio_componente VALUES (6, 1);
INSERT INTO dbo.Cambio_componente VALUES (6, 2);
INSERT INTO dbo.Cambio_componente VALUES (6, 3);
INSERT INTO dbo.Cambio_componente VALUES (6, 4);








