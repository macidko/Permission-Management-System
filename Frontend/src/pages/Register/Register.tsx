import React from "react";
import "./Register.css";
import { Container, Form, Button } from 'react-bootstrap';

type Props = {};

const Register = (props: Props) => {
  return (
    <Container fluid className="vh-100 bg-success d-flex align-items-center justify-content-center">
      <Form className="bg-secondary p-5 rounded">
        <Form.Group className="text-center text-white h1">
          <Form.Label className="font-weight-bold">REGISTER</Form.Label>
        </Form.Group>
        <Form.Group className="mb-3" controlId="formBasicEmail">
          <Form.Label>Email address</Form.Label>
          <Form.Control type="email" placeholder="Enter email" />
          <Form.Text className="text-muted">
            We'll never share your email with anyone else.
          </Form.Text>
        </Form.Group>

        <Form.Group className="mb-3" controlId="formBasicPassword">
          <Form.Label>Password</Form.Label>
          <Form.Control type="password" placeholder="Password" />
        </Form.Group>

        <Form.Group className="mb-3" controlId="formBasicPassword">
          <Form.Label>Confirm Password</Form.Label>
          <Form.Control type="password" placeholder="Confirm Password" />
        </Form.Group>
        <Button variant="primary" type="submit" className="float-end">
          Register
        </Button>
      </Form>
    </Container>
  );
};

export default Register;
