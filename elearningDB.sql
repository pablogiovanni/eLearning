CREATE DATABASE  IF NOT EXISTS `elearningdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `elearningdb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: sql_server    Database: elearningdb
-- ------------------------------------------------------
-- Server version	5.7.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aplicacion`
--

DROP TABLE IF EXISTS `aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aplicacion` (
  `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(80) NOT NULL,
  `habilitar_aplicacion` tinyint(1) NOT NULL,
  `id_reporte` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion`
--

LOCK TABLES `aplicacion` WRITE;
/*!40000 ALTER TABLE `aplicacion` DISABLE KEYS */;
INSERT INTO `aplicacion` VALUES (3,'app2','app2',1,''),(4,'Aplicacion3','app3',0,'');
/*!40000 ALTER TABLE `aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asig_detalle`
--

DROP TABLE IF EXISTS `asig_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asig_detalle` (
  `id_doc_asig` int(11) NOT NULL,
  `id_cur` int(11) NOT NULL,
  `id_fac` int(11) NOT NULL,
  `id_horario` int(11) NOT NULL,
  PRIMARY KEY (`id_doc_asig`,`id_cur`,`id_fac`),
  KEY `fk_asig_detalle_curso1_idx` (`id_cur`,`id_fac`),
  KEY `fk_asig_detalle_horario1_idx` (`id_horario`),
  KEY `fk_asig_detalle_asignacion_reg1_idx` (`id_doc_asig`),
  CONSTRAINT `fk_asig_detalle_asignacion_reg1` FOREIGN KEY (`id_doc_asig`) REFERENCES `asignacion_reg` (`id_doc_asig`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_asig_detalle_curso1` FOREIGN KEY (`id_cur`, `id_fac`) REFERENCES `curso` (`id_cur`, `facultad_id_fac`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_asig_detalle_horario1` FOREIGN KEY (`id_horario`) REFERENCES `horario` (`id_horario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asig_detalle`
--

LOCK TABLES `asig_detalle` WRITE;
/*!40000 ALTER TABLE `asig_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `asig_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asignacion_reg`
--

DROP TABLE IF EXISTS `asignacion_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asignacion_reg` (
  `id_doc_asig` int(11) NOT NULL AUTO_INCREMENT,
  `anio` tinyint(4) NOT NULL,
  `semestre` tinyint(4) NOT NULL,
  `inscripcionreg_id_insc` int(11) NOT NULL,
  `inscripcionreg_id_fac` int(11) NOT NULL,
  `fecha_creado` date NOT NULL,
  PRIMARY KEY (`id_doc_asig`,`anio`,`semestre`,`inscripcionreg_id_insc`,`inscripcionreg_id_fac`),
  KEY `fk_asignacion_reg_inscripcion_reg1_idx` (`inscripcionreg_id_insc`,`inscripcionreg_id_fac`),
  CONSTRAINT `fk_asignacion_reg_inscripcion_reg1` FOREIGN KEY (`inscripcionreg_id_insc`, `inscripcionreg_id_fac`) REFERENCES `inscripcion_reg` (`id_insc`, `id_fac`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asignacion_reg`
--

LOCK TABLES `asignacion_reg` WRITE;
/*!40000 ALTER TABLE `asignacion_reg` DISABLE KEYS */;
/*!40000 ALTER TABLE `asignacion_reg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bitacora` (
  `id_bitacora` int(11) NOT NULL AUTO_INCREMENT,
  `id_usuario` int(11) NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time(6) NOT NULL,
  `accion_usuario` varchar(45) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `resultado_bitacora` varchar(45) NOT NULL,
  `error_bitacora` varchar(120) NOT NULL,
  `ip_pc` varchar(45) NOT NULL,
  PRIMARY KEY (`id_bitacora`),
  KEY `FK_bitacora_usuario_idx` (`id_usuario`),
  CONSTRAINT `FK_bitacora_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catedratico`
--

DROP TABLE IF EXISTS `catedratico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `catedratico` (
  `id_cat` int(11) NOT NULL AUTO_INCREMENT,
  `personal_id_per` int(11) NOT NULL,
  `personal_id_reg` varchar(3) NOT NULL,
  PRIMARY KEY (`id_cat`,`personal_id_per`,`personal_id_reg`),
  KEY `fk_catedratico_personal_reg1_idx` (`personal_id_per`,`personal_id_reg`),
  CONSTRAINT `fk_catedratico_personal_reg1` FOREIGN KEY (`personal_id_per`, `personal_id_reg`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catedratico`
--

LOCK TABLES `catedratico` WRITE;
/*!40000 ALTER TABLE `catedratico` DISABLE KEYS */;
/*!40000 ALTER TABLE `catedratico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cur_material`
--

DROP TABLE IF EXISTS `cur_material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cur_material` (
  `id_mat` int(11) NOT NULL AUTO_INCREMENT,
  `ecurso_id_cur` int(11) NOT NULL,
  `ecurso_id_fac` int(11) NOT NULL,
  `ecurso_id_cat` int(11) NOT NULL,
  `nom_mat` varchar(45) NOT NULL,
  `path_mat` varchar(50) NOT NULL,
  PRIMARY KEY (`id_mat`,`ecurso_id_cur`,`ecurso_id_fac`,`ecurso_id_cat`),
  KEY `fk_cur_material_ecurso1_idx` (`ecurso_id_cur`,`ecurso_id_fac`,`ecurso_id_cat`),
  CONSTRAINT `fk_cur_material_ecurso1` FOREIGN KEY (`ecurso_id_cur`, `ecurso_id_fac`, `ecurso_id_cat`) REFERENCES `ecurso` (`curso_id_cur`, `curso_fac_fac`, `catid_cat`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cur_material`
--

LOCK TABLES `cur_material` WRITE;
/*!40000 ALTER TABLE `cur_material` DISABLE KEYS */;
/*!40000 ALTER TABLE `cur_material` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso`
--

DROP TABLE IF EXISTS `curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `curso` (
  `id_cur` int(11) NOT NULL AUTO_INCREMENT,
  `facultad_id_fac` int(11) NOT NULL,
  `nombre_cur` varchar(45) NOT NULL,
  `descrip_cur` varchar(128) NOT NULL,
  PRIMARY KEY (`id_cur`,`facultad_id_fac`),
  KEY `fk_curso_facultad1_idx` (`facultad_id_fac`),
  CONSTRAINT `fk_curso_facultad1` FOREIGN KEY (`facultad_id_fac`) REFERENCES `facultad` (`id_fac`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso`
--

LOCK TABLES `curso` WRITE;
/*!40000 ALTER TABLE `curso` DISABLE KEYS */;
/*!40000 ALTER TABLE `curso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dept`
--

DROP TABLE IF EXISTS `dept`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dept` (
  `id_dept` int(11) NOT NULL AUTO_INCREMENT,
  `nom_dept` varchar(14) COLLATE latin1_spanish_ci NOT NULL,
  PRIMARY KEY (`id_dept`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dept`
--

LOCK TABLES `dept` WRITE;
/*!40000 ALTER TABLE `dept` DISABLE KEYS */;
INSERT INTO `dept` VALUES (1,'Direccion');
/*!40000 ALTER TABLE `dept` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_aplicacion_derecho`
--

DROP TABLE IF EXISTS `detalle_aplicacion_derecho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_aplicacion_derecho` (
  `id_usuario` int(11) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(1) NOT NULL,
  `modificar` tinyint(1) NOT NULL,
  `eliminar` tinyint(1) NOT NULL,
  `imprimir` tinyint(1) NOT NULL,
  `consultar` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_usuario`,`id_aplicacion`),
  KEY `FK_detalle_usuario_idx` (`id_usuario`),
  KEY `FK_detalle_aplicacion2` (`id_aplicacion`),
  CONSTRAINT `FK_detalle_aplicacion2` FOREIGN KEY (`id_aplicacion`) REFERENCES `aplicacion` (`id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_detalle_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_aplicacion_derecho`
--

LOCK TABLES `detalle_aplicacion_derecho` WRITE;
/*!40000 ALTER TABLE `detalle_aplicacion_derecho` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_aplicacion_derecho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_foro`
--

DROP TABLE IF EXISTS `detalle_foro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_foro` (
  `foro_id_foro` int(11) NOT NULL,
  `personal_id_per` int(11) NOT NULL,
  `personal_id_reg` varchar(3) NOT NULL,
  PRIMARY KEY (`foro_id_foro`,`personal_id_per`,`personal_id_reg`),
  KEY `fk_detalle_alumno_personal_reg1_idx` (`personal_id_per`,`personal_id_reg`),
  CONSTRAINT `fk_detalle_alumno_foro1` FOREIGN KEY (`foro_id_foro`) REFERENCES `foro` (`id_foro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_alumno_personal_reg1` FOREIGN KEY (`personal_id_per`, `personal_id_reg`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_foro`
--

LOCK TABLES `detalle_foro` WRITE;
/*!40000 ALTER TABLE `detalle_foro` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_foro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_nota`
--

DROP TABLE IF EXISTS `detalle_nota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_nota` (
  `nota_reg_id` int(11) NOT NULL,
  `per_id_per` int(11) NOT NULL,
  `per_id_reg` varchar(3) NOT NULL,
  `nota_zona` tinyint(4) DEFAULT NULL,
  `nota_final` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`nota_reg_id`,`per_id_per`,`per_id_reg`),
  KEY `fk_detalle_nota_personal_reg1_idx` (`per_id_per`,`per_id_reg`),
  CONSTRAINT `fk_detalle_nota_nota_reg1` FOREIGN KEY (`nota_reg_id`) REFERENCES `nota_reg` (`id_nota_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_nota_personal_reg1` FOREIGN KEY (`per_id_per`, `per_id_reg`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_nota`
--

LOCK TABLES `detalle_nota` WRITE;
/*!40000 ALTER TABLE `detalle_nota` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_nota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `docs_reg`
--

DROP TABLE IF EXISTS `docs_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `docs_reg` (
  `id_doc` int(11) NOT NULL,
  `reg_id_per` int(11) NOT NULL,
  `personal_reg_id` varchar(3) NOT NULL,
  `ecurso_id_cur` int(11) NOT NULL,
  `ecurso_id_fac` int(11) NOT NULL,
  `ecurso_id_cat` int(11) NOT NULL,
  `docs_path` varchar(50) NOT NULL,
  `docs_date_in` datetime NOT NULL,
  `docs_nom_tarea` varchar(45) NOT NULL,
  PRIMARY KEY (`id_doc`,`reg_id_per`,`personal_reg_id`,`ecurso_id_cur`,`ecurso_id_fac`,`ecurso_id_cat`),
  KEY `fk_docs_reg_personal_reg1_idx` (`reg_id_per`,`personal_reg_id`),
  KEY `fk_docs_reg_ecurso1_idx` (`ecurso_id_cur`,`ecurso_id_fac`,`ecurso_id_cat`),
  CONSTRAINT `fk_docs_reg_ecurso1` FOREIGN KEY (`ecurso_id_cur`, `ecurso_id_fac`, `ecurso_id_cat`) REFERENCES `ecurso` (`curso_id_cur`, `curso_fac_fac`, `catid_cat`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_docs_reg_personal_reg1` FOREIGN KEY (`reg_id_per`, `personal_reg_id`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `docs_reg`
--

LOCK TABLES `docs_reg` WRITE;
/*!40000 ALTER TABLE `docs_reg` DISABLE KEYS */;
/*!40000 ALTER TABLE `docs_reg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ecurso`
--

DROP TABLE IF EXISTS `ecurso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ecurso` (
  `curso_id_cur` int(11) NOT NULL,
  `curso_fac_fac` int(11) NOT NULL,
  `catid_cat` int(11) NOT NULL,
  PRIMARY KEY (`curso_id_cur`,`curso_fac_fac`,`catid_cat`),
  KEY `fk_ecurso_curso1_idx` (`curso_id_cur`,`curso_fac_fac`),
  KEY `fk_ecurso_catedratico1_idx` (`catid_cat`),
  CONSTRAINT `fk_ecurso_catedratico1` FOREIGN KEY (`catid_cat`) REFERENCES `catedratico` (`id_cat`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ecurso_curso1` FOREIGN KEY (`curso_id_cur`, `curso_fac_fac`) REFERENCES `curso` (`id_cur`, `facultad_id_fac`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ecurso`
--

LOCK TABLES `ecurso` WRITE;
/*!40000 ALTER TABLE `ecurso` DISABLE KEYS */;
/*!40000 ALTER TABLE `ecurso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edificio`
--

DROP TABLE IF EXISTS `edificio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `edificio` (
  `id_ed` varchar(1) NOT NULL,
  `nom_ed` varchar(16) NOT NULL,
  PRIMARY KEY (`id_ed`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edificio`
--

LOCK TABLES `edificio` WRITE;
/*!40000 ALTER TABLE `edificio` DISABLE KEYS */;
/*!40000 ALTER TABLE `edificio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `email_reg`
--

DROP TABLE IF EXISTS `email_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `email_reg` (
  `id_email` varchar(50) NOT NULL,
  `reg_id_per` int(11) NOT NULL,
  `reg_id_reg` varchar(3) NOT NULL,
  PRIMARY KEY (`id_email`,`reg_id_per`,`reg_id_reg`),
  KEY `fk_email_reg_personal_reg1_idx` (`reg_id_per`,`reg_id_reg`),
  CONSTRAINT `fk_email_reg_personal_reg1` FOREIGN KEY (`reg_id_per`, `reg_id_reg`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `email_reg`
--

LOCK TABLES `email_reg` WRITE;
/*!40000 ALTER TABLE `email_reg` DISABLE KEYS */;
/*!40000 ALTER TABLE `email_reg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `id_emp` int(11) NOT NULL AUTO_INCREMENT,
  `personal_id_per` int(11) NOT NULL,
  `personal_id_reg` varchar(3) NOT NULL,
  PRIMARY KEY (`id_emp`,`personal_id_per`,`personal_id_reg`),
  KEY `fk_empleado_personal_reg1_idx` (`personal_id_per`,`personal_id_reg`),
  CONSTRAINT `fk_empleado_personal_reg1` FOREIGN KEY (`personal_id_per`, `personal_id_reg`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evaluacion`
--

DROP TABLE IF EXISTS `evaluacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `evaluacion` (
  `id_ev` int(11) NOT NULL AUTO_INCREMENT,
  `personal_id_per` int(11) NOT NULL,
  `personal_id_reg` varchar(3) NOT NULL,
  `ecurso_id_cur` int(11) NOT NULL,
  `ecurso_fac` int(11) NOT NULL,
  `ecurso_id_cat` int(11) NOT NULL,
  `nota_ev` int(11) NOT NULL,
  `fecha_init` date NOT NULL,
  `path_ev` varchar(128) NOT NULL,
  PRIMARY KEY (`id_ev`,`personal_id_per`,`personal_id_reg`,`ecurso_id_cur`,`ecurso_fac`,`ecurso_id_cat`),
  KEY `fk_evaluacion_personal_reg1_idx` (`personal_id_per`,`personal_id_reg`),
  KEY `fk_evaluacion_ecurso1_idx` (`ecurso_id_cur`,`ecurso_fac`,`ecurso_id_cat`),
  CONSTRAINT `fk_evaluacion_ecurso1` FOREIGN KEY (`ecurso_id_cur`, `ecurso_fac`, `ecurso_id_cat`) REFERENCES `ecurso` (`curso_id_cur`, `curso_fac_fac`, `catid_cat`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_evaluacion_personal_reg1` FOREIGN KEY (`personal_id_per`, `personal_id_reg`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evaluacion`
--

LOCK TABLES `evaluacion` WRITE;
/*!40000 ALTER TABLE `evaluacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `evaluacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `evento` (
  `id_evt` int(11) NOT NULL,
  `id_emp` int(11) NOT NULL,
  `fecha_ini` date NOT NULL,
  `fecha_fin` date NOT NULL,
  `nombre_ev` varchar(65) NOT NULL,
  `descrip_ev` varchar(256) NOT NULL,
  PRIMARY KEY (`id_evt`,`id_emp`),
  KEY `fk_evento_empleado1_idx` (`id_emp`),
  CONSTRAINT `fk_evento_empleado1` FOREIGN KEY (`id_emp`) REFERENCES `empleado` (`id_emp`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facultad`
--

DROP TABLE IF EXISTS `facultad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facultad` (
  `id_fac` int(11) NOT NULL AUTO_INCREMENT,
  `nom_fac` varchar(50) NOT NULL,
  `descrip_fac` varchar(128) NOT NULL,
  PRIMARY KEY (`id_fac`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facultad`
--

LOCK TABLES `facultad` WRITE;
/*!40000 ALTER TABLE `facultad` DISABLE KEYS */;
/*!40000 ALTER TABLE `facultad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `foro`
--

DROP TABLE IF EXISTS `foro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `foro` (
  `id_foro` int(11) NOT NULL AUTO_INCREMENT,
  `id_cat` int(11) NOT NULL,
  `tema_foro` varchar(65) NOT NULL,
  `fecha_creado` datetime NOT NULL,
  `fecha_fin` datetime NOT NULL,
  PRIMARY KEY (`id_foro`,`id_cat`),
  KEY `fk_foro_catedratico1_idx` (`id_cat`),
  CONSTRAINT `fk_foro_catedratico1` FOREIGN KEY (`id_cat`) REFERENCES `catedratico` (`id_cat`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `foro`
--

LOCK TABLES `foro` WRITE;
/*!40000 ALTER TABLE `foro` DISABLE KEYS */;
/*!40000 ALTER TABLE `foro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario`
--

DROP TABLE IF EXISTS `horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horario` (
  `id_horario` int(11) NOT NULL AUTO_INCREMENT,
  `curso_id_cur` int(11) NOT NULL,
  `curso_id_fac` int(11) NOT NULL,
  PRIMARY KEY (`id_horario`,`curso_id_cur`,`curso_id_fac`),
  KEY `fk_horario_detalle_curso1_idx` (`curso_id_cur`,`curso_id_fac`),
  CONSTRAINT `fk_horario_detalle_curso1` FOREIGN KEY (`curso_id_cur`, `curso_id_fac`) REFERENCES `curso` (`id_cur`, `facultad_id_fac`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario`
--

LOCK TABLES `horario` WRITE;
/*!40000 ALTER TABLE `horario` DISABLE KEYS */;
/*!40000 ALTER TABLE `horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario_detalle`
--

DROP TABLE IF EXISTS `horario_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horario_detalle` (
  `id_horario` int(11) NOT NULL,
  `edificio_id_ed` varchar(1) NOT NULL,
  `salon_id_salon` int(11) NOT NULL,
  `horario_dia` varchar(8) NOT NULL,
  `hora_ini` time NOT NULL,
  `hora_fin` varchar(45) NOT NULL,
  `seccion` varchar(1) NOT NULL,
  PRIMARY KEY (`id_horario`),
  KEY `fk_horario_detalle_salon1_idx` (`salon_id_salon`,`edificio_id_ed`),
  CONSTRAINT `fk_horario_detalle_horario1` FOREIGN KEY (`id_horario`) REFERENCES `horario` (`id_horario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_horario_detalle_salon1` FOREIGN KEY (`salon_id_salon`, `edificio_id_ed`) REFERENCES `salon` (`id_salon`, `edificio_id_ed`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario_detalle`
--

LOCK TABLES `horario_detalle` WRITE;
/*!40000 ALTER TABLE `horario_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `horario_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inscripcion_reg`
--

DROP TABLE IF EXISTS `inscripcion_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inscripcion_reg` (
  `id_insc` int(11) NOT NULL AUTO_INCREMENT,
  `id_fac` int(11) NOT NULL,
  `reg_id_per` int(11) NOT NULL,
  `reg_id_reg` varchar(3) NOT NULL,
  `fecha_reg` date NOT NULL,
  PRIMARY KEY (`id_insc`,`id_fac`,`reg_id_per`,`reg_id_reg`),
  KEY `fk_inscripcion_reg_facultad1_idx` (`id_fac`),
  KEY `fk_inscripcion_reg_personal_reg1` (`reg_id_per`,`reg_id_reg`),
  CONSTRAINT `fk_inscripcion_reg_facultad1` FOREIGN KEY (`id_fac`) REFERENCES `facultad` (`id_fac`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_inscripcion_reg_personal_reg1` FOREIGN KEY (`reg_id_per`, `reg_id_reg`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inscripcion_reg`
--

LOCK TABLES `inscripcion_reg` WRITE;
/*!40000 ALTER TABLE `inscripcion_reg` DISABLE KEYS */;
/*!40000 ALTER TABLE `inscripcion_reg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nota_reg`
--

DROP TABLE IF EXISTS `nota_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nota_reg` (
  `id_nota_reg` int(11) NOT NULL AUTO_INCREMENT,
  `nota_semestre` int(11) NOT NULL,
  `nota_anio` int(11) NOT NULL,
  `cur_id_curso` int(11) NOT NULL,
  `cur_id_fac` int(11) NOT NULL,
  `cat_id_cat` int(11) NOT NULL,
  `fecha_in` date NOT NULL,
  PRIMARY KEY (`id_nota_reg`,`nota_semestre`,`nota_anio`,`cur_id_curso`,`cur_id_fac`,`cat_id_cat`),
  KEY `fk_nota_reg_curso1_idx` (`cur_id_curso`,`cur_id_fac`),
  KEY `fk_nota_reg_catedratico1_idx` (`cat_id_cat`),
  CONSTRAINT `fk_nota_reg_catedratico1` FOREIGN KEY (`cat_id_cat`) REFERENCES `catedratico` (`id_cat`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_nota_reg_curso1` FOREIGN KEY (`cur_id_curso`, `cur_id_fac`) REFERENCES `curso` (`id_cur`, `facultad_id_fac`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nota_reg`
--

LOCK TABLES `nota_reg` WRITE;
/*!40000 ALTER TABLE `nota_reg` DISABLE KEYS */;
/*!40000 ALTER TABLE `nota_reg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `noticia`
--

DROP TABLE IF EXISTS `noticia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `noticia` (
  `id_noticia` int(11) NOT NULL,
  `id_emp` int(11) NOT NULL,
  `nom_noticia` varchar(65) NOT NULL,
  `fecha_creado` date NOT NULL,
  `fecha_noticia` date DEFAULT NULL,
  PRIMARY KEY (`id_noticia`,`id_emp`),
  KEY `fk_noticia_empleado1_idx` (`id_emp`),
  CONSTRAINT `fk_noticia_empleado1` FOREIGN KEY (`id_emp`) REFERENCES `empleado` (`id_emp`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `noticia`
--

LOCK TABLES `noticia` WRITE;
/*!40000 ALTER TABLE `noticia` DISABLE KEYS */;
/*!40000 ALTER TABLE `noticia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pais`
--

DROP TABLE IF EXISTS `pais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pais` (
  `id_pais` int(11) NOT NULL AUTO_INCREMENT,
  `nom_p` varchar(12) COLLATE latin1_spanish_ci NOT NULL,
  PRIMARY KEY (`id_pais`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pais`
--

LOCK TABLES `pais` WRITE;
/*!40000 ALTER TABLE `pais` DISABLE KEYS */;
INSERT INTO `pais` VALUES (1,'Guatemala');
/*!40000 ALTER TABLE `pais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personal_reg`
--

DROP TABLE IF EXISTS `personal_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personal_reg` (
  `id_per` int(11) NOT NULL AUTO_INCREMENT,
  `id_reg` varchar(3) NOT NULL,
  `nom_per` varchar(60) NOT NULL,
  `ape_per` varchar(60) NOT NULL,
  `fecha_creado` date NOT NULL,
  `fecha_nac` date NOT NULL,
  `obser` varchar(128) NOT NULL,
  `id_dept` int(11) NOT NULL,
  `id_pais` int(11) NOT NULL,
  `dir_per` varchar(65) NOT NULL,
  `id_tipo` int(11) NOT NULL,
  PRIMARY KEY (`id_per`,`id_reg`),
  KEY `fk_alumno_dept1_idx` (`id_dept`),
  KEY `fk_alumno_pais1_idx` (`id_pais`),
  KEY `fk_personal_reg_tipo_personal1_idx` (`id_tipo`),
  CONSTRAINT `fk_alumno_dept1` FOREIGN KEY (`id_dept`) REFERENCES `dept` (`id_dept`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_alumno_pais1` FOREIGN KEY (`id_pais`) REFERENCES `pais` (`id_pais`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_personal_reg_tipo_personal1` FOREIGN KEY (`id_tipo`) REFERENCES `tipo_personal` (`id_tipo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personal_reg`
--

LOCK TABLES `personal_reg` WRITE;
/*!40000 ALTER TABLE `personal_reg` DISABLE KEYS */;
INSERT INTO `personal_reg` VALUES (1,'emp','PabloGiovanni','CalderonLopez','2018-03-09','2000-01-01','DBA',1,1,'Z1.ave1Calle1 1-11',1);
/*!40000 ALTER TABLE `personal_reg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporteador`
--

DROP TABLE IF EXISTS `reporteador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reporteador` (
  `idReporte` int(11) NOT NULL,
  `nombreReporte` varchar(500) DEFAULT NULL,
  `path` varchar(500) DEFAULT NULL,
  `vista` int(11) DEFAULT NULL,
  PRIMARY KEY (`idReporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporteador`
--

LOCK TABLES `reporteador` WRITE;
/*!40000 ALTER TABLE `reporteador` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporteador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reportegeneral`
--

DROP TABLE IF EXISTS `reportegeneral`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reportegeneral` (
  `idReporteg` int(11) NOT NULL AUTO_INCREMENT,
  `nombreReporteg` varchar(65) NOT NULL,
  `pathr` varchar(128) NOT NULL,
  `reporte_app_id` int(11) NOT NULL,
  PRIMARY KEY (`idReporteg`),
  KEY `fk_app_id_idx` (`reporte_app_id`),
  CONSTRAINT `fk_app_id` FOREIGN KEY (`reporte_app_id`) REFERENCES `aplicacion` (`id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reportegeneral`
--

LOCK TABLES `reportegeneral` WRITE;
/*!40000 ALTER TABLE `reportegeneral` DISABLE KEYS */;
/*!40000 ALTER TABLE `reportegeneral` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salon`
--

DROP TABLE IF EXISTS `salon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salon` (
  `id_salon` int(11) NOT NULL AUTO_INCREMENT,
  `edificio_id_ed` varchar(1) NOT NULL,
  `capacidad` int(11) NOT NULL,
  PRIMARY KEY (`id_salon`,`edificio_id_ed`),
  KEY `fk_salon_edificio1_idx` (`edificio_id_ed`),
  CONSTRAINT `fk_salon_edificio1` FOREIGN KEY (`edificio_id_ed`) REFERENCES `edificio` (`id_ed`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salon`
--

LOCK TABLES `salon` WRITE;
/*!40000 ALTER TABLE `salon` DISABLE KEYS */;
/*!40000 ALTER TABLE `salon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tel_reg`
--

DROP TABLE IF EXISTS `tel_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tel_reg` (
  `id_tel` varchar(9) COLLATE latin1_spanish_ci NOT NULL,
  `area_code_tel` varchar(3) COLLATE latin1_spanish_ci NOT NULL,
  `asis_id_v` int(11) NOT NULL,
  `tel_prov_id_prov` int(11) NOT NULL,
  `tel_tipo_id_tp` int(11) NOT NULL,
  PRIMARY KEY (`id_tel`,`area_code_tel`,`asis_id_v`,`tel_prov_id_prov`,`tel_tipo_id_tp`),
  KEY `fk_tel_reg_tel_tipo1_idx` (`tel_tipo_id_tp`),
  CONSTRAINT `fk_tel_reg_tel_tipo1` FOREIGN KEY (`tel_tipo_id_tp`) REFERENCES `tel_tipo` (`id_tp`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tel_reg`
--

LOCK TABLES `tel_reg` WRITE;
/*!40000 ALTER TABLE `tel_reg` DISABLE KEYS */;
/*!40000 ALTER TABLE `tel_reg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tel_tipo`
--

DROP TABLE IF EXISTS `tel_tipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tel_tipo` (
  `id_tp` int(11) NOT NULL AUTO_INCREMENT,
  `nom_tp` varchar(10) COLLATE latin1_spanish_ci NOT NULL,
  PRIMARY KEY (`id_tp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tel_tipo`
--

LOCK TABLES `tel_tipo` WRITE;
/*!40000 ALTER TABLE `tel_tipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tel_tipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefono`
--

DROP TABLE IF EXISTS `telefono`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefono` (
  `id_tel` varchar(16) NOT NULL,
  `area_code` varchar(6) NOT NULL,
  `reg_id_per` int(11) NOT NULL,
  `reg_id_reg` varchar(3) NOT NULL,
  PRIMARY KEY (`id_tel`,`area_code`,`reg_id_per`,`reg_id_reg`),
  KEY `fk_telefono_personal_reg1_idx` (`reg_id_per`,`reg_id_reg`),
  CONSTRAINT `fk_telefono_personal_reg1` FOREIGN KEY (`reg_id_per`, `reg_id_reg`) REFERENCES `personal_reg` (`id_per`, `id_reg`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefono`
--

LOCK TABLES `telefono` WRITE;
/*!40000 ALTER TABLE `telefono` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefono` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_personal`
--

DROP TABLE IF EXISTS `tipo_personal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_personal` (
  `id_tipo` int(11) NOT NULL AUTO_INCREMENT,
  `nom_tipo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_tipo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_personal`
--

LOCK TABLES `tipo_personal` WRITE;
/*!40000 ALTER TABLE `tipo_personal` DISABLE KEYS */;
INSERT INTO `tipo_personal` VALUES (1,'Administrativo'),(2,'Alumno'),(3,'Catedratico');
/*!40000 ALTER TABLE `tipo_personal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `correo_usuario` varchar(45) DEFAULT NULL,
  `telefono_usuario` int(8) DEFAULT NULL,
  `contrasena` blob,
  `per_id` int(11) NOT NULL,
  `per_reg_id` varchar(3) NOT NULL,
  PRIMARY KEY (`id_usuario`,`per_id`,`per_reg_id`),
  UNIQUE KEY `usuario_UNIQUE` (`usuario`),
  KEY `fk_usuario_personal_reg1_idx` (`per_id`,`per_reg_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (10,'pcalderon','Pablo','Calderon','correo@abc.com',87654321,'!\Ó¡\—\–tU]êdû≤∏\Â',1,'emp');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'elearningdb'
--

--
-- Dumping routines for database 'elearningdb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-10 11:33:33
