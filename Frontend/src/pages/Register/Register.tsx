import React from "react";
import "./Register.css";
import { Container, Form, Button, Image } from "react-bootstrap";
import { Link } from "react-router-dom";
import Logo from "../../assets/pmsLogo3.png";
import { Formik } from "formik";
import * as Yup from "yup";

type Props = {};

const validationSchema = Yup.object().shape({
  email: Yup.string()
    .email("Geçerli bir email adresi girin")
    .required("Email gerekli"),
  password: Yup.string().required("Şifre gerekli"),
  confirmPassword: Yup.string()
    .oneOf([Yup.ref("password"), undefined], "Şifreler eşleşmiyor")
    .required("Şifreyi onayla gerekli"),
});

const Register = (props: Props) => {
  return (
    <Container
      fluid
      className="vh-100 d-flex align-items-center justify-content-center"
    >
      <Link to="/" className="m-2 h2 text-black">
        &larr;
      </Link>
      <Formik
        initialValues={{ email: "", password: "", confirmPassword: "" }}
        validationSchema={validationSchema}
        onSubmit={(values) => {
          console.log(values);
        }}
      >
        {({
          values,
          errors,
          touched,
          handleChange,
          handleBlur,
          handleSubmit,
        }) => (
          <Form
            id="register-form"
            className="p-5 rounded"
            onSubmit={handleSubmit}
          >
            <Form.Group className="text-center text-white h1">
              <Link to="/">
                <Image src={Logo} className="formLogo"></Image>
              </Link>
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicEmail">
              <Form.Label>Email Adresi</Form.Label>
              <Form.Control
                type="email"
                name="email"
                placeholder="Email"
                onChange={handleChange}
                onBlur={handleBlur}
                value={values.email}
                isInvalid={touched.email && !!errors.email}
              />
              <Form.Control.Feedback type="invalid">
                {errors.email}
              </Form.Control.Feedback>
            </Form.Group>

            <Form.Group className="mb-3" controlId="formBasicPassword">
              <Form.Label>Şifre</Form.Label>
              <Form.Control
                type="password"
                name="password"
                placeholder="Şifre"
                onChange={handleChange}
                onBlur={handleBlur}
                value={values.password}
                isInvalid={touched.password && !!errors.password}
              />
              <Form.Control.Feedback type="invalid">
                {errors.password}
              </Form.Control.Feedback>
            </Form.Group>

            <Form.Group className="mb-3" controlId="formConfirmPassword">
              <Form.Label>Şifreyi Onayla</Form.Label>
              <Form.Control
                type="password"
                name="confirmPassword"
                placeholder="Şifre Tekrar"
                onChange={handleChange}
                onBlur={handleBlur}
                value={values.confirmPassword}
                isInvalid={touched.confirmPassword && !!errors.confirmPassword}
              />
              <Form.Control.Feedback type="invalid">
                {errors.confirmPassword}
              </Form.Control.Feedback>
            </Form.Group>
            <Button variant="light" className="float-start">
              <Link
                to="/login"
                className="text-dark text-decoration-none align-center"
              >
                Giriş Yap
              </Link>
            </Button>
            <Button variant="dark" type="submit" className="float-end">
              Kayıt Ol
            </Button>
          </Form>
        )}
      </Formik>
      <Link to="/login" className="m-2 h2 text-black">
        &rarr;
      </Link>
    </Container>
  );
};

export default Register;
